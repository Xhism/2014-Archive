using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___HTML_Dispatcher
{
    class ElementBuilder
    {
        private string tag;
        private string opening;
        private string content;
        private string closing;
        private bool isVoid;
        public ElementBuilder(string tag, bool isVoid = false)
        {
            this.Tag = tag;
            this.IsVoid = isVoid;
            this.Content = string.Empty;
            this.Opening = "<" + this.Tag + ">";
            if (this.IsVoid)
            {
                //this.Opening = "<" + this.Tag + " />";
                this.Closing = string.Empty;
            }
            else
            {
                this.Closing = "</" + this.Tag + ">";
            }
        }
        private string Tag
        {
            get { return this.tag; }
            set
            {
                if (null == value) throw new ArgumentNullException();
                this.tag = value;
            }
        }
        public string Opening
        {
            get { return this.opening; }
            set
            {
                if (null == value) throw new ArgumentNullException();
                this.opening = value;
            }
        }
        public string Content
        {
            get { return this.content; }
            set
            {
                if (null == value) throw new ArgumentNullException();
                this.content = value;
            }
        }
        public string Closing
        {
            get { return this.closing; }
            set
            {
                if (null == value) throw new ArgumentNullException();
                this.closing = value;
            }
        }
        public bool IsVoid
        {
            get { return this.isVoid; }
            set { this.isVoid = value; }
        }
        public static string operator *(ElementBuilder elBld, int counter)
        {
            StringBuilder elementSB = new StringBuilder();
            for (int i = 0; i < counter; i++)
            {
                elementSB.Append(elBld.ToString());
            }
            return elementSB.ToString();
        }
        public string AddAttribute(string attr, string value)
        {
            this.Opening = this.Opening.TrimEnd(new[] { '/', '>', ' ' }) + string.Format(" {0}=\"{1}\"", attr, value);
            this.Opening += ">";
            return this.Opening;
        }
        public void AddContent(string content)
        {
            if (!this.IsVoid)
            {
                this.Content = content;
            }
            else throw new ArgumentException("Void HTML Elements cannot have content");
        }
        public override string ToString()
        {
            return this.Opening + this.Content + this.Closing;
        }
    }
}
