using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;

namespace Nomina.Opciones
{
    public partial class FrmEditFormula : DevExpress.XtraEditors.XtraForm
    {
        public FrmEditFormula()
        {
            InitializeComponent();
        }
        private void CreateTreeData()
        {
            DataSourcesNode.Nodes.Clear();
            foreach(DataSet s in DataSets)
            {
                var w = treeList1.AppendNode(new object() {}, DataSourcesNode);
                w.SetValue(0, s.DataSetName);
                foreach(DataTable t in s.Tables)
                {
                    var a = treeList1.AppendNode(new object() {}, w);
                    a.SetValue(0,t.TableName);
                    foreach (DataColumn col in t.Columns)
                    {
                        var q = treeList1.AppendNode(new object() {}, a);
                        q.SetValue(0,col.ColumnName);
                        q.Tag = col;
                    }

                }
            }
          
            foreach (FuncData funcData in Formulas.Functions)
            {
                var w = treeList1.AppendNode(new object() {}, FuncNode);
                w.SetValue(0,funcData.Name);
                w.Tag = funcData;

            }

        }

 
        

        public TreeListNode FuncNode { get { return treeList1.Nodes[0]; } }
        public TreeListNode DataSourcesNode { get { return treeList1.Nodes[1]; } }
        private List<DataSet> _dataset;
        public FrmFormulas Formulas { get; set; }
        public List<DataSet> DataSets { get { return _dataset; } set { _dataset = value;
        CreateTreeData();
            //mathparser.DataSets = value;
        } }


        private void treeList1_DoubleClick(object sender, EventArgs e)
        {


            if (treeList1.FocusedNode!=null)
            {
                if (treeList1.FocusedNode.Tag == null)
                    return;
                
                var t = treeList1.FocusedNode;
                var s = " ";
                if (treeList1.FocusedNode.Tag is FuncData)
                    s = " Function." + treeList1.FocusedNode.GetValue(0) + " ";
                else
                    while (t.Level >= 1)
                    {
                        if (t.Level > 1)
                            s = s.Insert(0, '.' + t.GetValue(0).ToString());
                        else
                            s = s.Insert(0, " dbo." + t.GetValue(0).ToString());
                        t = t.ParentNode;
                    }
                memoEdit1.Text = memoEdit1.Text.Insert(memoEdit1.Text.Length, s);

            }
        }
       
      private MathParser mathparser = new MathParser();

        public String Function { get { return memoEdit1.Text; } set { memoEdit1.Text = value; } }
        
        private void ucPieFormulario1_Aceptar(object sender)
        {
            //mathparser.String = memoEdit1.Text;
            //mathparser.Name = Name;
            //String s = "";
            //if (!mathparser.CheckForErrors(out s))
            //{
            //    DialogResult = DialogResult.OK;
            //    Close();

            //}
            //else
            //{


            //}
        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        } 
    }
}