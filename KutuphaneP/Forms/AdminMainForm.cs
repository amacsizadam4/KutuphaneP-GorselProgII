﻿using KutuphaneP.Forms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneP.Forms
{
    public partial class AdminMainForm: Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addBook = new AdminUploadForm();
            addBook.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var deleteBook = new AdminDeleteBook();
            deleteBook.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var deleteCategory = new AdminDeleteCategory();
            deleteCategory.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addCategory = new AdminAddCategory();
            addCategory.ShowDialog();

        }
    }
}
