namespace kollok
{
    partial class MainForm
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
            this.listBoxEquipment = new System.Windows.Forms.ListBox();
            this.listBoxBooking = new System.Windows.Forms.ListBox();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEquipment
            // 
            this.listBoxEquipment.FormattingEnabled = true;
            this.listBoxEquipment.ItemHeight = 16;
            this.listBoxEquipment.Location = new System.Drawing.Point(28, 21);
            this.listBoxEquipment.Name = "listBoxEquipment";
            this.listBoxEquipment.Size = new System.Drawing.Size(327, 196);
            this.listBoxEquipment.TabIndex = 0;
            // 
            // listBoxBooking
            // 
            this.listBoxBooking.FormattingEnabled = true;
            this.listBoxBooking.ItemHeight = 16;
            this.listBoxBooking.Location = new System.Drawing.Point(28, 333);
            this.listBoxBooking.Name = "listBoxBooking";
            this.listBoxBooking.Size = new System.Drawing.Size(327, 196);
            this.listBoxBooking.TabIndex = 1;
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(509, 81);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(168, 84);
            this.buttonBook.TabIndex = 2;
            this.buttonBook.Text = "Забронировать";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(509, 378);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(168, 84);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Проверка";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 607);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.listBoxBooking);
            this.Controls.Add(this.listBoxEquipment);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Бронь техники";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEquipment;
        private System.Windows.Forms.ListBox listBoxBooking;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonCheck;
    }
}

