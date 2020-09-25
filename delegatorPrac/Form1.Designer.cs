namespace delegatorPrac
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSort1 = new System.Windows.Forms.Button();
            this.btnSort2 = new System.Windows.Forms.Button();
            this.btnSort3 = new System.Windows.Forms.Button();
            this.btnSortRest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.DataSource = this.productBindingSource;
            this.listBoxProduct.DisplayMember = "NamePrice";
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.ItemHeight = 12;
            this.listBoxProduct.Location = new System.Drawing.Point(10, 10);
            this.listBoxProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(281, 112);
            this.listBoxProduct.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(delegatorPrac.Product);
            this.productBindingSource.CurrentChanged += new System.EventHandler(this.productBindingSource_CurrentChanged);
            // 
            // btnSort1
            // 
            this.btnSort1.Location = new System.Drawing.Point(10, 126);
            this.btnSort1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort1.Name = "btnSort1";
            this.btnSort1.Size = new System.Drawing.Size(136, 18);
            this.btnSort1.TabIndex = 1;
            this.btnSort1.Text = "정렬(함수이름사용)";
            this.btnSort1.UseVisualStyleBackColor = true;
            this.btnSort1.Click += new System.EventHandler(this.btnSort1_Click);
            // 
            // btnSort2
            // 
            this.btnSort2.Location = new System.Drawing.Point(10, 149);
            this.btnSort2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort2.Name = "btnSort2";
            this.btnSort2.Size = new System.Drawing.Size(136, 18);
            this.btnSort2.TabIndex = 2;
            this.btnSort2.Text = "정렬(익명 델리게이터)";
            this.btnSort2.UseVisualStyleBackColor = true;
            this.btnSort2.Click += new System.EventHandler(this.btnSort2_Click);
            // 
            // btnSort3
            // 
            this.btnSort3.Location = new System.Drawing.Point(152, 126);
            this.btnSort3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort3.Name = "btnSort3";
            this.btnSort3.Size = new System.Drawing.Size(139, 18);
            this.btnSort3.TabIndex = 3;
            this.btnSort3.Text = "정렬(람다)";
            this.btnSort3.UseVisualStyleBackColor = true;
            this.btnSort3.Click += new System.EventHandler(this.btnSort3_Click);
            // 
            // btnSortRest
            // 
            this.btnSortRest.Location = new System.Drawing.Point(152, 149);
            this.btnSortRest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortRest.Name = "btnSortRest";
            this.btnSortRest.Size = new System.Drawing.Size(139, 18);
            this.btnSortRest.TabIndex = 4;
            this.btnSortRest.Text = "정렬 초기화";
            this.btnSortRest.UseVisualStyleBackColor = true;
            this.btnSortRest.Click += new System.EventHandler(this.btnSortRest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 366);
            this.Controls.Add(this.btnSortRest);
            this.Controls.Add(this.btnSort3);
            this.Controls.Add(this.btnSort2);
            this.Controls.Add(this.btnSort1);
            this.Controls.Add(this.listBoxProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.Button btnSort1;
        private System.Windows.Forms.Button btnSort2;
        private System.Windows.Forms.Button btnSort3;
        private System.Windows.Forms.Button btnSortRest;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}

