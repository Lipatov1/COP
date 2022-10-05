﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;
using System;

namespace LipatovVisualComponents {
    public partial class LipatovTreeView : UserControl {
        private List<string> treeHierarchy;

        public LipatovTreeView() {
            InitializeComponent();
            treeHierarchy = new List<string>();
        }

        [Category("Пользовательская категория"), Description("Выбранная ветка")]
        public int SelectedBranchIndex {
            get => treeView.SelectedNode.Index;
            set {
                if (value < treeView.Nodes.Count) {
                    treeView.SelectedNode = treeView.Nodes[value];
                    treeView.Focus();
                }
            }
        }

        public T GetSelectedNode<T>() {
            TreeNode selectedNode = treeView.SelectedNode;
            T item = (T)Activator.CreateInstance(typeof(T));

            while (selectedNode.Parent != null) {
                var memberInfo = item.GetType().GetMember(selectedNode.Name).FirstOrDefault();

                if (memberInfo != null)
                    switch (memberInfo.MemberType) {
                        case MemberTypes.Property:
                            item.GetType().GetProperty(selectedNode.Name).SetValue(item, selectedNode.Text);
                            break;
                        case MemberTypes.Field:
                            item.GetType().GetField(selectedNode.Name).SetValue(item, selectedNode.Text);
                            break;
                    }

                selectedNode = selectedNode.Parent;
            }

            return item;
        }

        public void AddItem<T>(T item) {
            TreeNode parentNode = null;

            // Проходим по каждому свойству дерева
            foreach (var hierarchyLevel in treeHierarchy) {
                // Получаем значение свойства из пришедшего объекта
                string value = GetValue(item, hierarchyLevel);

                TreeNode node;
                // Является ли текущее свойство листовым
                bool isLeafNode = treeHierarchy[treeHierarchy.Count - 1] == hierarchyLevel;

                // Не является листовым и есть такой элемент в дереве
                if (!isLeafNode && IsAlreadyInTree(value, parentNode)) {
                    if (parentNode != null) {
                        node = parentNode.Nodes.Find(value, false).FirstOrDefault();
                    }
                    else {
                        // Если узел уже сущетсвует - ищем его
                        node = treeView.Nodes.Find(value, false).FirstOrDefault();
                    }
                }
                else {
                    if (parentNode != null) {
                        node = parentNode.Nodes.Add(value, value);
                    }
                    else {
                        node = treeView.Nodes.Add(value, value);
                    }
                }

                parentNode = node;
            }
        }

        private string GetValue<T>(T item, string name) {
            var bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
            var memberInfo = item.GetType().GetMember(name, bindingFlags).FirstOrDefault();

            if (memberInfo == null) {
                throw new ArgumentException();
            }

            string value;
            switch (memberInfo.MemberType) {
                case MemberTypes.Property:
                    value = (string)item.GetType().GetProperty(name, bindingFlags).GetValue(item);
                    break;
                case MemberTypes.Field:
                    value = (string)item.GetType().GetField(name, bindingFlags).GetValue(item);
                    break;
                default:
                    throw new ArgumentException();
            }

            return value;
        }

        private bool IsAlreadyInTree(string value, TreeNode parentNode) {
            return parentNode != null && parentNode.Nodes.Find(value, false).Any() || treeView.Nodes.Find(value, false).Any();
        }

        public void SetHierarchy(List<string> hierarchy) {
            if (hierarchy != null) {
                treeHierarchy = hierarchy;
            }
        }
    }
}