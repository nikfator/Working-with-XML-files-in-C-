using System.Xml;
using System.Xml.Schema;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private const string xmlFilePath = "payroll.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.AllowUserToAddRows)
            {
                dataGridView1.AllowUserToAddRows = false;
            }
            else
            {
                dataGridView1.AllowUserToAddRows = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {

            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();

                if (File.Exists(xmlFilePath))
                {
                    xmlDoc.Load(xmlFilePath);
                }
                else
                {
                    XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    xmlDoc.AppendChild(xmlDeclaration);

                    XmlElement root = xmlDoc.CreateElement("payroll");
                    xmlDoc.AppendChild(root);
                }

                XmlElement rootElement = xmlDoc.DocumentElement;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    XmlElement employee = xmlDoc.CreateElement("employee");

                    XmlElement id = xmlDoc.CreateElement("id");
                    id.InnerText = row.Cells["colId"].Value?.ToString();
                    employee.AppendChild(id);

                    XmlElement name = xmlDoc.CreateElement("name");
                    name.InnerText = row.Cells["colName"].Value?.ToString();
                    employee.AppendChild(name);

                    XmlElement position = xmlDoc.CreateElement("position");
                    position.InnerText = row.Cells["colPosition"].Value?.ToString();
                    employee.AppendChild(position);

                    XmlElement salary = xmlDoc.CreateElement("salary");
                    salary.InnerText = row.Cells["colSalary"].Value?.ToString();
                    employee.AppendChild(salary);

                    XmlElement hoursWorked = xmlDoc.CreateElement("hours_worked");
                    hoursWorked.InnerText = row.Cells["colHoursWorked"].Value?.ToString();
                    employee.AppendChild(hoursWorked);

                    XmlElement deductions = xmlDoc.CreateElement("deductions");

                    XmlElement tax = xmlDoc.CreateElement("tax");
                    tax.InnerText = row.Cells["colTax"].Value?.ToString();
                    deductions.AppendChild(tax);

                    XmlElement insurance = xmlDoc.CreateElement("insurance");
                    insurance.InnerText = row.Cells["colInsurance"].Value?.ToString();
                    deductions.AppendChild(insurance);

                    employee.AppendChild(deductions);
                    rootElement.AppendChild(employee);
                }

                xmlDoc.Save(xmlFilePath);

                MessageBox.Show("Данные добавлены в файл.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteId = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(deleteId))
            {
                MessageBox.Show("Введите ID для удаления.");
                return;
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            XmlNodeList employees = xmlDoc.SelectNodes("//employee");

            bool found = false;
            foreach (XmlNode employee in employees)
            {
                if (employee.SelectSingleNode("id").InnerText == deleteId)
                {
                    employee.ParentNode.RemoveChild(employee);
                    found = true;
                    break;
                }
            }

            if (found)
            {
                xmlDoc.Save(xmlFilePath);
                MessageBox.Show("Информация о сотруднике удалена.");
            }
            else
            {
                MessageBox.Show("Сотрудник с указанным ID не найден.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);
            if (xmlDoc != null)
            {
                try
                {
                    // Находим первый элемент <employee>
                    XmlNode employeeNode = xmlDoc.DocumentElement.SelectSingleNode("employee");

                    // Добавляем новый атрибут
                    XmlAttribute attribute = xmlDoc.CreateAttribute("newAttribute");
                    attribute.Value = "newValue";
                    employeeNode.Attributes.Append(attribute);

                    // Сохраняем изменения в файл
                    xmlDoc.Save(xmlFilePath);

                    // Добавляем новую колонку в DataGridView
                    dataGridView1.Columns.Add(attribute.Name, attribute.Name);

                    MessageBox.Show("Атрибут успешно добавлен.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении атрибута: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("XML-документ не загружен.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);
            if (xmlDoc != null)
            {
                try
                {
                    // Находим первый элемент <employee>
                    XmlNode employeeNode = xmlDoc.DocumentElement.SelectSingleNode("employee");

                    // Проверяем, существует ли атрибут
                    if (employeeNode.Attributes["newAttribute"] != null)
                    {
                        // Удаляем атрибут
                        employeeNode.Attributes.RemoveNamedItem("newAttribute");

                        // Сохраняем изменения в файл
                        xmlDoc.Save(xmlFilePath);

                        // Удаляем колонку из DataGridView
                        dataGridView1.Columns.Remove("newAttribute");

                        MessageBox.Show("Атрибут успешно удален.");
                    }
                    else
                    {
                        MessageBox.Show("Атрибут не найден.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении атрибута: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("XML-документ не загружен.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadXmlFileIntoTextBox();
        }
        private bool ValidateData()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; // Пропускаем строку для добавления новых данных

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex != dataGridView1.Columns["colName"].Index && string.IsNullOrWhiteSpace(Convert.ToString(cell.Value)))
                    {
                        MessageBox.Show("Пожалуйста, заполните все ячейки.");
                        return false;
                    }

                    if (cell.ColumnIndex == dataGridView1.Columns["colSalary"].Index ||
                        cell.ColumnIndex == dataGridView1.Columns["colHoursWorked"].Index ||
                        cell.ColumnIndex == dataGridView1.Columns["colTax"].Index ||
                        cell.ColumnIndex == dataGridView1.Columns["colInsurance"].Index)
                    {
                        if (!decimal.TryParse(Convert.ToString(cell.Value), out _))
                        {
                            MessageBox.Show("Пожалуйста, введите числовое значение в колонках Зарплата, Отработанные часы, Налоги и Страховки.");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void LoadXmlFileIntoTextBox()
        {
            if (File.Exists(xmlFilePath))
            {
                try
                {
                    // Читаем содержимое файла XML в строку
                    string xmlContent = File.ReadAllText(xmlFilePath);

                    // Устанавливаем содержимое файла XML в textBox
                    textBox1.Text = xmlContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Файл XML не найден.");
            }
        }
        private void LoadPayrollData()
        {
            if (File.Exists(xmlFilePath))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(xmlFilePath);

                    dataGridView1.Rows.Clear();

                    foreach (XmlNode employeeNode in xmlDoc.DocumentElement.SelectNodes("employee"))
                    {
                        string id = employeeNode.SelectSingleNode("id").InnerText;
                        string name = employeeNode.SelectSingleNode("name").InnerText;
                        string position = employeeNode.SelectSingleNode("position").InnerText;
                        string salary = employeeNode.SelectSingleNode("salary").InnerText;
                        string hoursWorked = employeeNode.SelectSingleNode("hours_worked").InnerText;
                        string tax = employeeNode.SelectSingleNode("deductions/tax").InnerText;
                        string insurance = employeeNode.SelectSingleNode("deductions/insurance").InnerText;

                        dataGridView1.Rows.Add(id, name, position, salary, hoursWorked, tax, insurance);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
                }
            }
        }
        private void CopyNode(XmlDocument xmlDoc, string id)
        {
            XmlNode originalNode = xmlDoc.SelectSingleNode($"//employee[id='{id}']");
            if (originalNode != null)
            {
                XmlNode copiedNode = originalNode.CloneNode(true);
                xmlDoc.DocumentElement.AppendChild(copiedNode);
                xmlDoc.Save(xmlFilePath);
                MessageBox.Show($"Узел с id '{id}' успешно скопирован.");
            }
            else
            {
                MessageBox.Show($"Сотрудник с id '{id}' не найден.");
            }
        }
        private void AddAttribute(XmlDocument xmlDoc, string id, string attributeName, string attributeValue)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"//employee[id='{id}']");
            if (node != null)
            {
                XmlAttribute newAttribute = xmlDoc.CreateAttribute(attributeName);
                newAttribute.Value = attributeValue;
                node.Attributes.Append(newAttribute);
                xmlDoc.Save(xmlFilePath);
                MessageBox.Show($"Атрибут '{attributeName}' успешно добавлен к узлу с id '{id}'.");
            }
            else
            {
                MessageBox.Show($"Сотрудник с id '{id}' не найден.");
            }
        }
        private void RemoveAttribute(XmlDocument xmlDoc, string id, string attributeName)
        {
            XmlNode node = xmlDoc.SelectSingleNode($"//employee[id='{id}']");
            if (node != null && node.Attributes[attributeName] != null)
            {
                node.Attributes.RemoveNamedItem(attributeName);
                xmlDoc.Save(xmlFilePath);
                MessageBox.Show($"Атрибут '{attributeName}' успешно удален из узла с id '{id}'.");
            }
            else
            {
                MessageBox.Show($"Сотрудник с id '{id}' не найден или у него нет атрибута '{attributeName}'.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Введите ID сотрудника для копирования.");
                return;
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);
            CopyNode(xmlDoc, id);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string id = textBox4.Text.Trim();
            string elementName = textBox5.Text.Trim();
            string elementValue = textBox6.Text.Trim();
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(elementName) || string.IsNullOrEmpty(elementValue))
            {
                MessageBox.Show("Введите ID сотрудника, имя элемента и его значение для добавления.");
                return;
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            // Поиск узла <employee> по id
            XmlNode employeeNode = xmlDoc.SelectSingleNode($"//employee[id='{id}']");
            if (employeeNode != null)
            {
                // Создаем новый элемент с указанным именем
                XmlElement newElement = xmlDoc.CreateElement(elementName);
                newElement.InnerText = elementValue;

                // Добавляем новый элемент к узлу <employee>
                employeeNode.AppendChild(newElement);

                // Сохраняем изменения в файл
                xmlDoc.Save(xmlFilePath);
                MessageBox.Show($"Элемент '{elementName}' успешно добавлен к узлу с id '{id}' со значением '{elementValue}'.");
            }
            else
            {
                MessageBox.Show($"Сотрудник с id '{id}' не найден.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string id = textBox7.Text.Trim();
            string elementName = textBox8.Text.Trim();
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(elementName))
            {
                MessageBox.Show("Введите ID сотрудника и имя элемента для удаления.");
                return;
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            // Поиск узла <employee> по id
            XmlNode employeeNode = xmlDoc.SelectSingleNode($"//employee[id='{id}']");
            if (employeeNode != null)
            {
                // Поиск элемента по имени
                XmlNode elementNode = employeeNode.SelectSingleNode(elementName);
                if (elementNode != null)
                {
                    // Удаляем элемент из узла <employee>
                    employeeNode.RemoveChild(elementNode);

                    // Сохраняем изменения в файл
                    xmlDoc.Save(xmlFilePath);
                    MessageBox.Show($"Элемент '{elementName}' успешно удален у узла с id '{id}'.");
                }
                else
                {
                    MessageBox.Show($"У узла с id '{id}' нет элемента с именем '{elementName}'.");
                }
            }
            else
            {
                MessageBox.Show($"Сотрудник с id '{id}' не найден.");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                XmlSchemaSet schema = new XmlSchemaSet();
                schema.Add("", "schema.xsd");
                XmlDocument doc = new XmlDocument();
                doc.Load("payroll.xml");
                doc.Schemas.Add(schema);
                doc.Validate(null);
                MessageBox.Show("XML документ соответствует схеме XSD.");
            }
            catch (XmlSchemaValidationException ex)
            {
                MessageBox.Show("Ошибка валидации XML документа: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
