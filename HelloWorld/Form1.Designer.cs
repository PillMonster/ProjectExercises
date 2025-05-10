namespace HelloWorld
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labHelloWorld = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.labTime = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.groupBoxHello = new System.Windows.Forms.GroupBox();
            this.groupBoxCount = new System.Windows.Forms.GroupBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.groupBoxHello.SuspendLayout();
            this.groupBoxCount.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // labHelloWorld
            // 
            this.labHelloWorld.AutoSize = true;
            this.labHelloWorld.BackColor = System.Drawing.SystemColors.Window;
            this.labHelloWorld.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHelloWorld.Location = new System.Drawing.Point(44, 40);
            this.labHelloWorld.Name = "labHelloWorld";
            this.labHelloWorld.Size = new System.Drawing.Size(115, 16);
            this.labHelloWorld.TabIndex = 0;
            this.labHelloWorld.Text = "                           ";
            this.labHelloWorld.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(35, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Say Hello Button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.BackColor = System.Drawing.SystemColors.Window;
            this.labCount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCount.Location = new System.Drawing.Point(71, 40);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(47, 16);
            this.labCount.TabIndex = 2;
            this.labCount.Text = "          ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(44, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Count Button";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerCount
            // 
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.SystemColors.Window;
            this.labTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTime.Location = new System.Drawing.Point(24, 40);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(87, 16);
            this.labTime.TabIndex = 4;
            this.labTime.Text = "                    ";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // groupBoxHello
            // 
            this.groupBoxHello.Controls.Add(this.button1);
            this.groupBoxHello.Controls.Add(this.labHelloWorld);
            this.groupBoxHello.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxHello.Location = new System.Drawing.Point(51, 114);
            this.groupBoxHello.Name = "groupBoxHello";
            this.groupBoxHello.Size = new System.Drawing.Size(200, 100);
            this.groupBoxHello.TabIndex = 5;
            this.groupBoxHello.TabStop = false;
            this.groupBoxHello.Text = "1. 建立 Hello World 專案";
            // 
            // groupBoxCount
            // 
            this.groupBoxCount.Controls.Add(this.button2);
            this.groupBoxCount.Controls.Add(this.labCount);
            this.groupBoxCount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxCount.Location = new System.Drawing.Point(270, 114);
            this.groupBoxCount.Name = "groupBoxCount";
            this.groupBoxCount.Size = new System.Drawing.Size(200, 100);
            this.groupBoxCount.TabIndex = 6;
            this.groupBoxCount.TabStop = false;
            this.groupBoxCount.Text = "3. 實作 Count to 10 功能";
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.labTime);
            this.groupBoxTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxTime.Location = new System.Drawing.Point(494, 114);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTime.TabIndex = 7;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "4. 實作動態顯示時間功能";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.groupBoxCount);
            this.Controls.Add(this.groupBoxHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxHello.ResumeLayout(false);
            this.groupBoxHello.PerformLayout();
            this.groupBoxCount.ResumeLayout(false);
            this.groupBoxCount.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labHelloWorld;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.GroupBox groupBoxHello;
        private System.Windows.Forms.GroupBox groupBoxCount;
        private System.Windows.Forms.GroupBox groupBoxTime;
    }
}

