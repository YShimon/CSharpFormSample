namespace Mvvm.Views
{
    partial class SampleView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.executeButton = new System.Windows.Forms.Button();
            this.input1TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(420, 12);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(150, 42);
            this.executeButton.TabIndex = 0;
            this.executeButton.Text = "Command";
            this.executeButton.UseVisualStyleBackColor = true;
            // 
            // input1TextBox
            // 
            this.input1TextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.input1TextBox.Location = new System.Drawing.Point(12, 12);
            this.input1TextBox.Name = "input1TextBox";
            this.input1TextBox.Size = new System.Drawing.Size(400, 39);
            this.input1TextBox.TabIndex = 1;
            this.input1TextBox.Text = "Text";
            // 
            // SampleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 86);
            this.Controls.Add(this.input1TextBox);
            this.Controls.Add(this.executeButton);
            this.Name = "SampleView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.TextBox input1TextBox;
    }
}

