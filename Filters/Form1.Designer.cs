namespace Filters
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.воттенкахсерогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьяркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переносToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волны60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волны30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеклоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыймирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.собеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличениярезкостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.динамическоеразмытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.щарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прюиттаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светящиесякраяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матМорфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растяжениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сужениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.раскрытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tophatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьструктурныйэлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Cancel = new System.Windows.Forms.Button();
            this.StepBack = new System.Windows.Forms.Button();
            this.StepForward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(284, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.матМорфологияToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.воттенкахсерогоToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.увеличитьяркостьToolStripMenuItem,
            this.переносToolStripMenuItem,
            this.поворотToolStripMenuItem,
            this.волны60ToolStripMenuItem,
            this.волны30ToolStripMenuItem,
            this.стеклоToolStripMenuItem,
            this.медианныйToolStripMenuItem,
            this.максимумToolStripMenuItem,
            this.серыймирToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // воттенкахсерогоToolStripMenuItem
            // 
            this.воттенкахсерогоToolStripMenuItem.Name = "воттенкахсерогоToolStripMenuItem";
            this.воттенкахсерогоToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.воттенкахсерогоToolStripMenuItem.Text = "В оттенках серого";
            this.воттенкахсерогоToolStripMenuItem.Click += new System.EventHandler(this.воттенкахсерогоToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // увеличитьяркостьToolStripMenuItem
            // 
            this.увеличитьяркостьToolStripMenuItem.Name = "увеличитьяркостьToolStripMenuItem";
            this.увеличитьяркостьToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.увеличитьяркостьToolStripMenuItem.Text = "Увеличить яркость";
            this.увеличитьяркостьToolStripMenuItem.Click += new System.EventHandler(this.увеличитьяркостьToolStripMenuItem_Click);
            // 
            // переносToolStripMenuItem
            // 
            this.переносToolStripMenuItem.Name = "переносToolStripMenuItem";
            this.переносToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.переносToolStripMenuItem.Text = "Перенос";
            this.переносToolStripMenuItem.Click += new System.EventHandler(this.переносToolStripMenuItem_Click);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.поворотToolStripMenuItem.Text = "Поворот";
            this.поворотToolStripMenuItem.Click += new System.EventHandler(this.поворотToolStripMenuItem_Click);
            // 
            // волны60ToolStripMenuItem
            // 
            this.волны60ToolStripMenuItem.Name = "волны60ToolStripMenuItem";
            this.волны60ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.волны60ToolStripMenuItem.Text = "Волны60";
            this.волны60ToolStripMenuItem.Click += new System.EventHandler(this.волны60ToolStripMenuItem_Click);
            // 
            // волны30ToolStripMenuItem
            // 
            this.волны30ToolStripMenuItem.Name = "волны30ToolStripMenuItem";
            this.волны30ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.волны30ToolStripMenuItem.Text = "Волны30";
            this.волны30ToolStripMenuItem.Click += new System.EventHandler(this.волны30ToolStripMenuItem_Click);
            // 
            // стеклоToolStripMenuItem
            // 
            this.стеклоToolStripMenuItem.Name = "стеклоToolStripMenuItem";
            this.стеклоToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.стеклоToolStripMenuItem.Text = "Стекло";
            this.стеклоToolStripMenuItem.Click += new System.EventHandler(this.стеклоToolStripMenuItem_Click);
            // 
            // медианныйToolStripMenuItem
            // 
            this.медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            this.медианныйToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.медианныйToolStripMenuItem.Text = "Медианный";
            this.медианныйToolStripMenuItem.Click += new System.EventHandler(this.медианныйToolStripMenuItem_Click);
            // 
            // максимумToolStripMenuItem
            // 
            this.максимумToolStripMenuItem.Name = "максимумToolStripMenuItem";
            this.максимумToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.максимумToolStripMenuItem.Text = "Максимум";
            this.максимумToolStripMenuItem.Click += new System.EventHandler(this.максимумToolStripMenuItem_Click);
            // 
            // серыймирToolStripMenuItem
            // 
            this.серыймирToolStripMenuItem.Name = "серыймирToolStripMenuItem";
            this.серыймирToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.серыймирToolStripMenuItem.Text = "Серый мир";
            this.серыймирToolStripMenuItem.Click += new System.EventHandler(this.серыймирToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.гауссаToolStripMenuItem1,
            this.собеляToolStripMenuItem,
            this.увеличениярезкостиToolStripMenuItem,
            this.тиснениеToolStripMenuItem,
            this.динамическоеразмытиеToolStripMenuItem,
            this.щарраToolStripMenuItem,
            this.прюиттаToolStripMenuItem,
            this.светящиесякраяToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // гауссаToolStripMenuItem1
            // 
            this.гауссаToolStripMenuItem1.Name = "гауссаToolStripMenuItem1";
            this.гауссаToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.гауссаToolStripMenuItem1.Text = "Гаусса";
            this.гауссаToolStripMenuItem1.Click += new System.EventHandler(this.гауссаToolStripMenuItem1_Click);
            // 
            // собеляToolStripMenuItem
            // 
            this.собеляToolStripMenuItem.Name = "собеляToolStripMenuItem";
            this.собеляToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.собеляToolStripMenuItem.Text = "Собеля (градиент яркости)";
            this.собеляToolStripMenuItem.Click += new System.EventHandler(this.собеляToolStripMenuItem_Click);
            // 
            // увеличениярезкостиToolStripMenuItem
            // 
            this.увеличениярезкостиToolStripMenuItem.Name = "увеличениярезкостиToolStripMenuItem";
            this.увеличениярезкостиToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.увеличениярезкостиToolStripMenuItem.Text = "Увеличения резкости";
            this.увеличениярезкостиToolStripMenuItem.Click += new System.EventHandler(this.увеличениярезкостиToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.тиснениеToolStripMenuItem.Text = "Тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
            // 
            // динамическоеразмытиеToolStripMenuItem
            // 
            this.динамическоеразмытиеToolStripMenuItem.Name = "динамическоеразмытиеToolStripMenuItem";
            this.динамическоеразмытиеToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.динамическоеразмытиеToolStripMenuItem.Text = "Динамическое размытие";
            this.динамическоеразмытиеToolStripMenuItem.Click += new System.EventHandler(this.динамическоеразмытиеToolStripMenuItem_Click);
            // 
            // щарраToolStripMenuItem
            // 
            this.щарраToolStripMenuItem.Name = "щарраToolStripMenuItem";
            this.щарраToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.щарраToolStripMenuItem.Text = "Щарра";
            this.щарраToolStripMenuItem.Click += new System.EventHandler(this.щарраToolStripMenuItem_Click);
            // 
            // прюиттаToolStripMenuItem
            // 
            this.прюиттаToolStripMenuItem.Name = "прюиттаToolStripMenuItem";
            this.прюиттаToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.прюиттаToolStripMenuItem.Text = "Прюитта";
            this.прюиттаToolStripMenuItem.Click += new System.EventHandler(this.прюиттаToolStripMenuItem_Click);
            // 
            // светящиесякраяToolStripMenuItem
            // 
            this.светящиесякраяToolStripMenuItem.Name = "светящиесякраяToolStripMenuItem";
            this.светящиесякраяToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.светящиесякраяToolStripMenuItem.Text = "Светящиеся края";
            this.светящиесякраяToolStripMenuItem.Click += new System.EventHandler(this.светящиесякраяToolStripMenuItem_Click);
            // 
            // матМорфологияToolStripMenuItem
            // 
            this.матМорфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.растяжениеToolStripMenuItem,
            this.сужениеToolStripMenuItem,
            this.закрытиеToolStripMenuItem,
            this.раскрытиеToolStripMenuItem,
            this.tophatToolStripMenuItem,
            this.изменитьструктурныйэлементToolStripMenuItem});
            this.матМорфологияToolStripMenuItem.Name = "матМорфологияToolStripMenuItem";
            this.матМорфологияToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.матМорфологияToolStripMenuItem.Text = "Мат. морфология";
            // 
            // растяжениеToolStripMenuItem
            // 
            this.растяжениеToolStripMenuItem.Name = "растяжениеToolStripMenuItem";
            this.растяжениеToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.растяжениеToolStripMenuItem.Text = "Растяжение";
            this.растяжениеToolStripMenuItem.Click += new System.EventHandler(this.растяжениеToolStripMenuItem_Click);
            // 
            // сужениеToolStripMenuItem
            // 
            this.сужениеToolStripMenuItem.Name = "сужениеToolStripMenuItem";
            this.сужениеToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.сужениеToolStripMenuItem.Text = "Сужение";
            this.сужениеToolStripMenuItem.Click += new System.EventHandler(this.сужениеToolStripMenuItem_Click);
            // 
            // закрытиеToolStripMenuItem
            // 
            this.закрытиеToolStripMenuItem.Name = "закрытиеToolStripMenuItem";
            this.закрытиеToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.закрытиеToolStripMenuItem.Text = "Закрытие";
            this.закрытиеToolStripMenuItem.Click += new System.EventHandler(this.закрытиеToolStripMenuItem_Click);
            // 
            // раскрытиеToolStripMenuItem
            // 
            this.раскрытиеToolStripMenuItem.Name = "раскрытиеToolStripMenuItem";
            this.раскрытиеToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.раскрытиеToolStripMenuItem.Text = "Раскрытие";
            this.раскрытиеToolStripMenuItem.Click += new System.EventHandler(this.раскрытиеToolStripMenuItem_Click);
            // 
            // tophatToolStripMenuItem
            // 
            this.tophatToolStripMenuItem.Name = "tophatToolStripMenuItem";
            this.tophatToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.tophatToolStripMenuItem.Text = "Top-hat";
            this.tophatToolStripMenuItem.Click += new System.EventHandler(this.tophatToolStripMenuItem_Click);
            // 
            // изменитьструктурныйэлементToolStripMenuItem
            // 
            this.изменитьструктурныйэлементToolStripMenuItem.Name = "изменитьструктурныйэлементToolStripMenuItem";
            this.изменитьструктурныйэлементToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.изменитьструктурныйэлементToolStripMenuItem.Text = "Изменить структурный элемент";
            this.изменитьструктурныйэлементToolStripMenuItem.Click += new System.EventHandler(this.изменитьструктурныйэлементToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 376);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(129, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 405);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(259, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // StepBack
            // 
            this.StepBack.Location = new System.Drawing.Point(147, 376);
            this.StepBack.Name = "StepBack";
            this.StepBack.Size = new System.Drawing.Size(59, 23);
            this.StepBack.TabIndex = 4;
            this.StepBack.Text = "Назад";
            this.StepBack.UseVisualStyleBackColor = true;
            this.StepBack.Click += new System.EventHandler(this.StepBack_Click);
            // 
            // StepForward
            // 
            this.StepForward.Location = new System.Drawing.Point(212, 376);
            this.StepForward.Name = "StepForward";
            this.StepForward.Size = new System.Drawing.Size(59, 23);
            this.StepForward.TabIndex = 5;
            this.StepForward.Text = "Вперёд";
            this.StepForward.UseVisualStyleBackColor = true;
            this.StepForward.Click += new System.EventHandler(this.StepForward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.StepForward);
            this.Controls.Add(this.StepBack);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матМорфологияToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button StepBack;
        private System.Windows.Forms.Button StepForward;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гауссаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem воттенкахсерогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьяркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличениярезкостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переносToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волны60ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волны30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеклоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem динамическоеразмытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem щарраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прюиттаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светящиесякраяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимумToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыймирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem растяжениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сужениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem раскрытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tophatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьструктурныйэлементToolStripMenuItem;
    }
}

