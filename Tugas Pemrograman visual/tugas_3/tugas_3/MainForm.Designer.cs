/*
 * Created by SharpDevelop.
 * User: FERDI NAINGGOLAN
 * Date: 12/18/2021
 * Time: 7:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SMDB
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.TextBox();
			this.alamat = new System.Windows.Forms.TextBox();
			this.kelas = new System.Windows.Forms.TextBox();
			this.btnTambah = new System.Windows.Forms.Button();
			this.btnUbah = new System.Windows.Forms.Button();
			this.btnHapus = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(16, 2);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(7);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(803, 201);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellContentClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 281);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 45);
			this.label2.TabIndex = 2;
			this.label2.Text = "nama_siswa";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 330);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "alamat";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 386);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 33);
			this.label4.TabIndex = 4;
			this.label4.Text = "kelas";
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(206, 281);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(308, 35);
			this.name.TabIndex = 6;
			// 
			// alamat
			// 
			this.alamat.Location = new System.Drawing.Point(206, 330);
			this.alamat.Name = "alamat";
			this.alamat.Size = new System.Drawing.Size(308, 35);
			this.alamat.TabIndex = 7;
			// 
			// kelas
			// 
			this.kelas.Location = new System.Drawing.Point(206, 386);
			this.kelas.Name = "kelas";
			this.kelas.Size = new System.Drawing.Size(308, 35);
			this.kelas.TabIndex = 8;
			// 
			// btnTambah
			// 
			this.btnTambah.Location = new System.Drawing.Point(584, 234);
			this.btnTambah.Name = "btnTambah";
			this.btnTambah.Size = new System.Drawing.Size(137, 65);
			this.btnTambah.TabIndex = 9;
			this.btnTambah.Text = "Tambah";
			this.btnTambah.UseVisualStyleBackColor = true;
			this.btnTambah.Click += new System.EventHandler(this.BtnTambahClick);
			// 
			// btnUbah
			// 
			this.btnUbah.Location = new System.Drawing.Point(584, 326);
			this.btnUbah.Name = "btnUbah";
			this.btnUbah.Size = new System.Drawing.Size(137, 68);
			this.btnUbah.TabIndex = 10;
			this.btnUbah.Text = "Ubah";
			this.btnUbah.UseVisualStyleBackColor = true;
			this.btnUbah.Click += new System.EventHandler(this.BtnUbahClick);
			// 
			// btnHapus
			// 
			this.btnHapus.Location = new System.Drawing.Point(584, 419);
			this.btnHapus.Name = "btnHapus";
			this.btnHapus.Size = new System.Drawing.Size(137, 65);
			this.btnHapus.TabIndex = 11;
			this.btnHapus.Text = "Hapus";
			this.btnHapus.UseVisualStyleBackColor = true;
			this.btnHapus.Click += new System.EventHandler(this.BtnHapusClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 234);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 35);
			this.label1.TabIndex = 12;
			this.label1.Text = "id";
			// 
			// id
			// 
			this.id.Location = new System.Drawing.Point(206, 234);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(308, 35);
			this.id.TabIndex = 13;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 696);
			this.Controls.Add(this.id);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnHapus);
			this.Controls.Add(this.btnUbah);
			this.Controls.Add(this.btnTambah);
			this.Controls.Add(this.kelas);
			this.Controls.Add(this.alamat);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "MainForm";
			this.Text = "SMDB";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnHapus;
		private System.Windows.Forms.Button btnUbah;
		private System.Windows.Forms.Button btnTambah;
		private System.Windows.Forms.TextBox kelas;
		private System.Windows.Forms.TextBox alamat;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox id;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}
