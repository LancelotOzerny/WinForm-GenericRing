namespace GenericRingForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataValues = new System.Windows.Forms.ListBox();
            this.label_addTitle = new System.Windows.Forms.Label();
            this.input_addItem = new System.Windows.Forms.TextBox();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_findedIndex = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.input_findedResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_CurrentElement = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_ItemCounts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataValues
            // 
            this.dataValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataValues.FormattingEnabled = true;
            this.dataValues.ItemHeight = 24;
            this.dataValues.Location = new System.Drawing.Point(14, 13);
            this.dataValues.Name = "dataValues";
            this.dataValues.Size = new System.Drawing.Size(288, 484);
            this.dataValues.TabIndex = 0;
            // 
            // label_addTitle
            // 
            this.label_addTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_addTitle.AutoSize = true;
            this.label_addTitle.Location = new System.Drawing.Point(344, 13);
            this.label_addTitle.Name = "label_addTitle";
            this.label_addTitle.Size = new System.Drawing.Size(180, 24);
            this.label_addTitle.TabIndex = 1;
            this.label_addTitle.Text = "Добавить элемент";
            this.label_addTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_addItem
            // 
            this.input_addItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_addItem.Location = new System.Drawing.Point(320, 56);
            this.input_addItem.Name = "input_addItem";
            this.input_addItem.Size = new System.Drawing.Size(235, 29);
            this.input_addItem.TabIndex = 2;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addItem.Location = new System.Drawing.Point(320, 92);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(235, 36);
            this.btn_addItem.TabIndex = 3;
            this.btn_addItem.Text = "Добавить";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск по индексу";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_findedIndex
            // 
            this.input_findedIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_findedIndex.Location = new System.Drawing.Point(320, 201);
            this.input_findedIndex.Name = "input_findedIndex";
            this.input_findedIndex.Size = new System.Drawing.Size(52, 29);
            this.input_findedIndex.TabIndex = 2;
            // 
            // btn_find
            // 
            this.btn_find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_find.Location = new System.Drawing.Point(320, 237);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(235, 36);
            this.btn_find.TabIndex = 3;
            this.btn_find.Text = "Найти";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // input_findedResult
            // 
            this.input_findedResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_findedResult.Location = new System.Drawing.Point(378, 201);
            this.input_findedResult.Name = "input_findedResult";
            this.input_findedResult.ReadOnly = true;
            this.input_findedResult.Size = new System.Drawing.Size(177, 29);
            this.input_findedResult.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текущий элемент";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_CurrentElement
            // 
            this.input_CurrentElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input_CurrentElement.Location = new System.Drawing.Point(320, 356);
            this.input_CurrentElement.Name = "input_CurrentElement";
            this.input_CurrentElement.ReadOnly = true;
            this.input_CurrentElement.Size = new System.Drawing.Size(235, 29);
            this.input_CurrentElement.TabIndex = 2;
            this.input_CurrentElement.Text = "Нет";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(320, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_ItemCounts
            // 
            this.label_ItemCounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ItemCounts.AutoSize = true;
            this.label_ItemCounts.Location = new System.Drawing.Point(316, 470);
            this.label_ItemCounts.Name = "label_ItemCounts";
            this.label_ItemCounts.Size = new System.Drawing.Size(240, 24);
            this.label_ItemCounts.TabIndex = 1;
            this.label_ItemCounts.Text = "Количество элементов: 0";
            this.label_ItemCounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 503);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.input_CurrentElement);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.input_findedResult);
            this.Controls.Add(this.label_ItemCounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_findedIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_addItem);
            this.Controls.Add(this.label_addTitle);
            this.Controls.Add(this.dataValues);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dataValues;
        private System.Windows.Forms.Label label_addTitle;
        private System.Windows.Forms.TextBox input_addItem;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_findedIndex;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox input_findedResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_CurrentElement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_ItemCounts;
    }
}

