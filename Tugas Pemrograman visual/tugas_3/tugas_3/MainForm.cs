/*
 * Created by SharpDevelop.
 * User: FERDI NAINGGOLAN
 * Date: 12/18/2021
 * Time: 7:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;


namespace SMDB
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = sekolah; Uid= root");
    	MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
	
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			tampildata();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void tampildata(){
			
			try{
				mycommand.Connection=co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from datasiswa ";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds,"dftpesan")>0)
				{
					dataGridView.DataSource = ds;
					dataGridView.DataMember = "dftpesan";
				}
				co.Close();
			}
			catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
			}
		}
		
		public void insertData(){
			
			try{
				co.Open();
				mycommand.Connection= co;
				mycommand.CommandText= "insert into datasiswa values('"+id.Text+"','"+name.Text+"', '"+alamat.Text+"' ,  '"+kelas.Text+"')";
				myadapter.SelectCommand = mycommand;
					if(mycommand.ExecuteNonQuery()==1)
					{				
						MessageBox.Show("Data berhasildimasukkan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						tampildata();
				}
				co.Close();
		}
		catch (Exception ex){
			MessageBox.Show(ex.ToString());
			}
		}
		
		public void updateData(){
			try {
				co.Open();
				mycommand.CommandText="update datasiswa set id='"+id.Text+"', nama ='"+name.Text+"',alamat='"+alamat.Text+ "' ,kelas='"+kelas.Text+"' where id='"+id.Text+"'";
				myadapter.SelectCommand=mycommand;
				mycommand.ExecuteNonQuery();
				tampildata();
				co.Close();
				}
				catch (Exception ex)
					{
					MessageBox.Show(ex.ToString());
				}
			}
		
		public void deleteData(){
			
			try{
				co.Open();
				mycommand.CommandText="delete from datasiswa where id ='"+id.Text+"'";
				myadapter.SelectCommand = mycommand;
				mycommand.ExecuteNonQuery();
				tampildata();
			co.Close();
			}
			catch (Exception ex)
			{
			MessageBox.Show(ex.ToString());
		
			}
		}
		 
			
		
		void DataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			id.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
			name.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
			alamat.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
			kelas.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
		}
		
		void BtnTambahClick(object sender, EventArgs e)
		{
			tampildata();
		}
		
		void BtnUbahClick(object sender, EventArgs e)
		{
			updateData();
		}
		
		void BtnHapusClick(object sender, EventArgs e)
		{
			deleteData();
		}
	}

}