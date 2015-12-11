using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace NewspaperArticleBlog
{
    public class DocumentManager
    {
        public string _currentFile;
        public RichTextBox _textBox;
        public int fileFormatIndex;


        public DocumentManager(RichTextBox textBox)
        {
            _textBox = textBox;
        }


        public bool OpenDocument()
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == true)
            {
                _currentFile = dlg.FileName;

                using (Stream stream = dlg.OpenFile())
                {
                    TextRange range = new TextRange(_textBox.Document.ContentStart, _textBox.Document.ContentEnd);
                    range.Load(stream, DataFormats.Rtf);


                }

                return true;

            }

            else
                return false;
        }

        public void ApplyToSelection(DependencyProperty property, object value)
        {
            if (value != null)
            {
                _textBox.Selection.ApplyPropertyValue(property, value);
            }
        }

        public bool SaveDocumentAs()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Document (*.txt)|*.txt";
            fileFormatIndex = dlg.FilterIndex;

            if (dlg.ShowDialog() == true)
            {
                _currentFile = dlg.FileName;
                return SaveDocument();
            }

            return false;
        }


        public bool SaveDocument()
        {
            if (string.IsNullOrEmpty(_currentFile)) return SaveDocumentAs();
            else
            {
                using (Stream stream = new FileStream(_currentFile, FileMode.Create))
                {
                    TextRange range = new TextRange(_textBox.Document.ContentStart, _textBox.Document.ContentEnd);

                    switch (fileFormatIndex)
                    {
                        case 1: range.Save(stream, DataFormats.Rtf);
                            break;
                        case 2: range.Save(stream, DataFormats.Text);
                            break;
                    }


                }

                return true;
            }
        }



    }
}
