using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;
using ClassLib.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trees
{
    public partial class MainForm : Form
        
    {
        private List<TreeNodeModel> treeData_;
        private AnimalModel animalModel_;
        


        public MainForm()
        {
            InitializeComponent();
            treeData_ = new List<TreeNodeModel>();
            animalModel_ = new AnimalModel();
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            {
                treeData_.Add(new TreeNodeModel("Животные"));
                var AnimalNode = treeData_[0];
                var FishNode = AnimalNode.AddChildNode("Рыбы");
                FishNode.AddChildNode("Окунь");
                FishNode.AddChildNode("Карась");
                FishNode.AddChildNode("Щука");

                
                var birdsNode = AnimalNode.AddChildNode("Птицы");
                birdsNode.AddChildNode("Сорока");
                birdsNode.AddChildNode("Синица");
                birdsNode.AddChildNode("Кукушка");

                var insectsNode = AnimalNode.AddChildNode("Насекомые");
                insectsNode.AddChildNode("Муравей");
                insectsNode.AddChildNode("Стрекоза");
                insectsNode.AddChildNode("Колорадский жук");
            }
            FillTreeNodeCollection(treeData_, MyTreeView.Nodes);
            MyTreeView.ExpandAll();
            
            


        }
        static private void FillTreeNodeCollection(List<TreeNodeModel> sourceData, //данные источника - модели
                                                   TreeNodeCollection targetData) // данные приемника - представления
        {
            foreach (var node in sourceData)
            {
                var treeNode = new TreeNode(node.Name); // объект узла в представлении
                targetData.Add(treeNode); // добавили узел в дерево

                if (node.Children != null && node.Children.Count > 0)
                {
                    FillTreeNodeCollection(node.Children, treeNode.Nodes); //переносим дочерние элементы узла модели в дочерние элементы узла представления
                }
            }
        }
        

        private void MyTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.Nodes.Count == 0) // Проверяем, что это конечный узел (не группа)
            {
                Animal An = animalModel_.GetName(e.Node.Text); // Ищем животное по имени
                if (An != null)
                {
                    // Проверяем, есть ли уже такое животное в таблице
                    bool exists = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value?.ToString() == An.Name)
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        object[] newRow = { An.Name, An.Weight, An.Distribution_area, An.TypeOfAnimal };
                        dataGridView1.Rows.Add(newRow); // Добавляем новую строку
                    }
                    else
                    {
                        MessageBox.Show("Это животное уже есть в таблице!");
                    }
                }
                else
                {
                    MessageBox.Show("Животное не найдено!"); // Сообщение, если животное не найдено
                }
            }
            
        }
        private void сохранить_Click(object sender, EventArgs e)
        {

        }

        private void загрузить_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


