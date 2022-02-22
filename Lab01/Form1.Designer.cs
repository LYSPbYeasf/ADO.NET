
namespace DBConnection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.подключениеКБазеДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьСоединениеСБазойДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПодключенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеКБазеДанныхToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // подключениеКБазеДанныхToolStripMenuItem
            // 
            this.подключениеКБазеДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отключитьСоединениеСБазойДанныхToolStripMenuItem});
            this.подключениеКБазеДанныхToolStripMenuItem.Name = "подключениеКБазеДанныхToolStripMenuItem";
            this.подключениеКБазеДанныхToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.подключениеКБазеДанныхToolStripMenuItem.Text = "Подключение к Базе Данных ";
            this.подключениеКБазеДанныхToolStripMenuItem.Click += new System.EventHandler(this.подключениеКБазеДанныхToolStripMenuItem_Click);
            // 
            // отключитьСоединениеСБазойДанныхToolStripMenuItem
            // 
            this.отключитьСоединениеСБазойДанныхToolStripMenuItem.Name = "отключитьСоединениеСБазойДанныхToolStripMenuItem";
            this.отключитьСоединениеСБазойДанныхToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.отключитьСоединениеСБазойДанныхToolStripMenuItem.Text = "Отключить соединение с Базой Данных";
            this.отключитьСоединениеСБазойДанныхToolStripMenuItem.Click += new System.EventHandler(this.отключитьСоединениеСБазойДанныхToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПодключенийToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.файлToolStripMenuItem.Text = "Файл ";
            // 
            // списокПодключенийToolStripMenuItem
            // 
            this.списокПодключенийToolStripMenuItem.Name = "списокПодключенийToolStripMenuItem";
            this.списокПодключенийToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.списокПодключенийToolStripMenuItem.Text = "Список подключений";
            this.списокПодключенийToolStripMenuItem.Click += new System.EventHandler(this.списокПодключенийToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem подключениеКБазеДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключитьСоединениеСБазойДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПодключенийToolStripMenuItem;
    }
}

