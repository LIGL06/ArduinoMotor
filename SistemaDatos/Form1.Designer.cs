namespace SistemaDatos
{
    partial class mainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrame));
            this.enlaceBT = new System.IO.Ports.SerialPort(this.components);
            this.connect = new System.Windows.Forms.Button();
            this.offline = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.TXWINDOW = new System.Windows.Forms.TextBox();
            this.RXWINDOW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(12, 519);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(150, 30);
            this.connect.TabIndex = 0;
            this.connect.Text = "Conectar";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // offline
            // 
            this.offline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offline.Location = new System.Drawing.Point(422, 519);
            this.offline.Name = "offline";
            this.offline.Size = new System.Drawing.Size(150, 30);
            this.offline.TabIndex = 1;
            this.offline.Text = "Desconectar";
            this.offline.UseVisualStyleBackColor = true;
            this.offline.Click += new System.EventHandler(this.offline_Click);
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new System.Drawing.Point(220, 303);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(150, 30);
            this.send.TabIndex = 2;
            this.send.Text = "Enviar";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // TXWINDOW
            // 
            this.TXWINDOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXWINDOW.Location = new System.Drawing.Point(200, 200);
            this.TXWINDOW.Name = "TXWINDOW";
            this.TXWINDOW.Size = new System.Drawing.Size(200, 26);
            this.TXWINDOW.TabIndex = 3;
            // 
            // RXWINDOW
            // 
            this.RXWINDOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RXWINDOW.Location = new System.Drawing.Point(200, 430);
            this.RXWINDOW.Name = "RXWINDOW";
            this.RXWINDOW.Size = new System.Drawing.Size(200, 26);
            this.RXWINDOW.TabIndex = 4;
            this.RXWINDOW.TextChanged += new System.EventHandler(this.RXWINDOW_TextChanged);
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDatos.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.RXWINDOW);
            this.Controls.Add(this.TXWINDOW);
            this.Controls.Add(this.send);
            this.Controls.Add(this.offline);
            this.Controls.Add(this.connect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Adquisición de Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort enlaceBT;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button offline;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox TXWINDOW;
        private System.Windows.Forms.TextBox RXWINDOW;
    }
}

