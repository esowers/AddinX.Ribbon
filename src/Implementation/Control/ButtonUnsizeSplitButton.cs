using System.Xml.Linq;
using AddinX.Ribbon.Contract.Control.ButtonUnsize;

namespace AddinX.Ribbon.Implementation.Control
{
    public class ButtonUnsizeSplitButton : ButtonUnsize
    {
        public ButtonUnsizeSplitButton()
        {
            ElementName = "button";
            Id = new ElementId();
            imageVisible = false;
        }
        
        protected internal override XElement ToXml(XNamespace ns)
        {
            var tmpId = (ElementId)Id;
            var element = new XElement(ns + ElementName
                , new XAttribute(tmpId.Type.ToString(), tmpId.Value)
                , new XAttribute("showLabel", showLabel.ToString().ToLower())
                , imageVisible
                    ? string.IsNullOrEmpty(imageMso)
                        ? new XAttribute("image", imagePath)
                        : new XAttribute("imageMso", imageMso)
                    : new XAttribute("showImage", "false")
                , new XAttribute("getEnabled", "GetEnabled")
                , new XAttribute("onAction", "OnAction")
                , new XAttribute("tag", tmpId.Value)
                );

            if (!string.IsNullOrEmpty(Label))
            {
                element.Add(new XAttribute("label", Label));
            }

            if (!string.IsNullOrEmpty(screentip))
            {
                element.Add(new XAttribute("screentip", screentip));
            }

            if (!string.IsNullOrEmpty(supertip))
            {
                element.Add(new XAttribute("supertip", supertip));
            }

            if (!string.IsNullOrEmpty(keytip))
            {
                element.Add(new XAttribute("keytip", keytip));
            }

            if (!string.IsNullOrEmpty(description))
            {
                element.Add(new XAttribute("description", description));
            }

            return element;
        }
    }
}