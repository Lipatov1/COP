namespace TestWindowsFormsApp {
    partial class VisualComponentsTestForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent() {
            this.lipatovCheckedListBox = new LipatovVisualComponents.LipatovCheckedListBox();
            this.lipatovTextBox = new LipatovVisualComponents.LipatovTextBox();
            this.lipatovTreeView = new LipatovVisualComponents.LipatovTreeView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSetCheckedItems = new System.Windows.Forms.Button();
            this.buttonAddObjects = new System.Windows.Forms.Button();
            this.buttonSelectNode = new System.Windows.Forms.Button();
            this.buttonGetText = new System.Windows.Forms.Button();
            this.buttonSetText = new System.Windows.Forms.Button();
            this.buttonSetBadText = new System.Windows.Forms.Button();
            this.lipatovTreeView1 = new LipatovVisualComponents.LipatovTreeView();
            this.SuspendLayout();
            // 
            // lipatovCheckedListBox
            // 
            this.lipatovCheckedListBox.CheckedItems = new string[0];
            this.lipatovCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.lipatovCheckedListBox.Name = "lipatovCheckedListBox";
            this.lipatovCheckedListBox.Size = new System.Drawing.Size(216, 148);
            this.lipatovCheckedListBox.TabIndex = 0;
            // 
            // lipatovTextBox
            // 
            this.lipatovTextBox.InputText = null;
            this.lipatovTextBox.Location = new System.Drawing.Point(234, 12);
            this.lipatovTextBox.MaxLength = 15;
            this.lipatovTextBox.MinLength = 10;
            this.lipatovTextBox.Name = "lipatovTextBox";
            this.lipatovTextBox.Size = new System.Drawing.Size(216, 29);
            this.lipatovTextBox.TabIndex = 1;
            // 
            // lipatovTreeView
            // 
            this.lipatovTreeView.Location = new System.Drawing.Point(456, 12);
            this.lipatovTreeView.Name = "lipatovTreeView";
            this.lipatovTreeView.Size = new System.Drawing.Size(216, 148);
            this.lipatovTreeView.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 166);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(216, 32);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить элементы";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOutput
            // 
            this.buttonOutput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOutput.Location = new System.Drawing.Point(12, 204);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(216, 32);
            this.buttonOutput.TabIndex = 4;
            this.buttonOutput.Text = "Вывести элементы";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(12, 242);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(216, 32);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Очистить список";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSetCheckedItems
            // 
            this.buttonSetCheckedItems.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetCheckedItems.Location = new System.Drawing.Point(12, 280);
            this.buttonSetCheckedItems.Name = "buttonSetCheckedItems";
            this.buttonSetCheckedItems.Size = new System.Drawing.Size(216, 59);
            this.buttonSetCheckedItems.TabIndex = 6;
            this.buttonSetCheckedItems.Text = "Выделить \"Продукт 1\" и \"Продукт 2\"";
            this.buttonSetCheckedItems.UseVisualStyleBackColor = true;
            this.buttonSetCheckedItems.Click += new System.EventHandler(this.buttonSetCheckedItems_Click);
            // 
            // buttonAddObjects
            // 
            this.buttonAddObjects.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddObjects.Location = new System.Drawing.Point(456, 166);
            this.buttonAddObjects.Name = "buttonAddObjects";
            this.buttonAddObjects.Size = new System.Drawing.Size(216, 32);
            this.buttonAddObjects.TabIndex = 7;
            this.buttonAddObjects.Text = "Добавить объекты";
            this.buttonAddObjects.UseVisualStyleBackColor = true;
            this.buttonAddObjects.Click += new System.EventHandler(this.buttonAddObjects_Click);
            // 
            // buttonSelectNode
            // 
            this.buttonSelectNode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectNode.Location = new System.Drawing.Point(456, 204);
            this.buttonSelectNode.Name = "buttonSelectNode";
            this.buttonSelectNode.Size = new System.Drawing.Size(216, 32);
            this.buttonSelectNode.TabIndex = 8;
            this.buttonSelectNode.Text = "Выделить узел";
            this.buttonSelectNode.UseVisualStyleBackColor = true;
            this.buttonSelectNode.Click += new System.EventHandler(this.buttonSelectNode_Click);
            // 
            // buttonGetText
            // 
            this.buttonGetText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetText.Location = new System.Drawing.Point(234, 47);
            this.buttonGetText.Name = "buttonGetText";
            this.buttonGetText.Size = new System.Drawing.Size(216, 32);
            this.buttonGetText.TabIndex = 9;
            this.buttonGetText.Text = "Вывести текст";
            this.buttonGetText.UseVisualStyleBackColor = true;
            this.buttonGetText.Click += new System.EventHandler(this.buttonGetText_Click);
            // 
            // buttonSetText
            // 
            this.buttonSetText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetText.Location = new System.Drawing.Point(234, 85);
            this.buttonSetText.Name = "buttonSetText";
            this.buttonSetText.Size = new System.Drawing.Size(216, 59);
            this.buttonSetText.TabIndex = 10;
            this.buttonSetText.Text = "Изменить текст на \"Новый текст\"";
            this.buttonSetText.UseVisualStyleBackColor = true;
            this.buttonSetText.Click += new System.EventHandler(this.buttonSetText_Click);
            // 
            // buttonSetBadText
            // 
            this.buttonSetBadText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetBadText.Location = new System.Drawing.Point(234, 150);
            this.buttonSetBadText.Name = "buttonSetBadText";
            this.buttonSetBadText.Size = new System.Drawing.Size(216, 59);
            this.buttonSetBadText.TabIndex = 11;
            this.buttonSetBadText.Text = "Изменить текст на \"Новый текст123456\"";
            this.buttonSetBadText.UseVisualStyleBackColor = true;
            this.buttonSetBadText.Click += new System.EventHandler(this.buttonSetBadText_Click);
            // 
            // lipatovTreeView1
            // 
            this.lipatovTreeView1.Location = new System.Drawing.Point(456, 12);
            this.lipatovTreeView1.Name = "lipatovTreeView1";
            this.lipatovTreeView1.Size = new System.Drawing.Size(216, 148);
            this.lipatovTreeView1.TabIndex = 2;
            // 
            // VisualComponentsTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 350);
            this.Controls.Add(this.buttonSetBadText);
            this.Controls.Add(this.buttonSetText);
            this.Controls.Add(this.buttonGetText);
            this.Controls.Add(this.buttonSelectNode);
            this.Controls.Add(this.buttonAddObjects);
            this.Controls.Add(this.buttonSetCheckedItems);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.lipatovTreeView);
            this.Controls.Add(this.lipatovTextBox);
            this.Controls.Add(this.lipatovCheckedListBox);
            this.Name = "VisualComponentsTestForm";
            this.Text = "Тестовое приложение";
            this.ResumeLayout(false);
        }

        #endregion

        private LipatovVisualComponents.LipatovCheckedListBox lipatovCheckedListBox;
        private LipatovVisualComponents.LipatovTextBox lipatovTextBox;
        private LipatovVisualComponents.LipatovTreeView lipatovTreeView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSetCheckedItems;
        private System.Windows.Forms.Button buttonAddObjects;
        private System.Windows.Forms.Button buttonSelectNode;
        private System.Windows.Forms.Button buttonGetText;
        private System.Windows.Forms.Button buttonSetText;
        private System.Windows.Forms.Button buttonSetBadText;
        private LipatovVisualComponents.LipatovTreeView lipatovTreeView1;
    }
}