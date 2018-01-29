﻿using System.Xml.Linq;
using AddinX.Ribbon.Contract.Control.ToggleButtonUnsize;

namespace AddinX.Ribbon.Implementation.Control
{
    public class ToggleButtonUnsize : Control, IToggleButtonUnsize
    {
        protected bool imageVisible;
        protected string imageMso;
        protected string imagePath;
        protected bool showLabel;
        protected string description;
        protected string supertip;
        protected string screentip;
        protected string keytip;

        public ToggleButtonUnsize()
        {
            ElementName = "toggleButton";
            Id = new ElementId();
            imageVisible = false;
        }

        protected internal IToggleButtonUnsizeId SetLabel(string value)
        {
            Label = value;
            return this;
        }

        protected internal override XElement ToXml(XNamespace ns)
        {
            var tmpId = (ElementId)Id;
            var element = new XElement(ns + ElementName
                , new XAttribute(tmpId.Type.ToString(), tmpId.Value)
                , new XAttribute("label", Label)
                , imageVisible
                    ? string.IsNullOrEmpty(imageMso)
                        ? new XAttribute("image", imagePath)
                        : new XAttribute("imageMso", imageMso)
                    : new XAttribute("showImage", "false")
                , new XAttribute("showLabel", showLabel)
                , new XAttribute("getEnabled", "GetEnabled")
                , new XAttribute("getVisible", "GetVisible")
                , new XAttribute("onAction", "OnActionPressed")
                , new XAttribute("getPressed", "GetPressed")
                , new XAttribute("tag", tmpId.Value)
                );

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

        public IToggleButtonUnsizeLabel SetId(string name)
        {
            Id = new ElementId().SetId(name);
            return this;
        }

        public IToggleButtonUnsizeLabel SetIdMso(string name)
        {
            Id = new ElementId().SetMicrosoftId(name);
            return this;
        }

        public IToggleButtonUnsizeLabel SetIdQ(string ns, string name)
        {
            Id = new ElementId().SetNamespaceId(ns, name);
            return this;
        }

        public IToggleButtonUnsizeExtra ImageMso(string name)
        {
            imageVisible = true;
            imageMso = name;
            return this;
        }

        public IToggleButtonUnsizeExtra ImagePath(string name)
        {
            imageVisible = true;
            imagePath = name;
            return this;
        }

        public IToggleButtonUnsizeExtra NoImage()
        {
            imageVisible = false;
            return this;
        }

        public IToggleButtonUnsizeImage ShowLabel()
        {
            showLabel = true;
            return this;
        }

        public IToggleButtonUnsizeImage HideLabel()
        {
            showLabel = false;
            return this;
        }
        
        public IToggleButtonUnsizeExtra Description(string description)
        {
            this.description = description;
            return this;
        }

        public IToggleButtonUnsizeExtra Supertip(string supertip)
        {
            this.supertip = supertip;
            return this;
        }

        public IToggleButtonUnsizeExtra Keytip(string keytip)
        {
            this.keytip = keytip;
            return this;
        }

        public IToggleButtonUnsizeExtra Screentip(string screentip)
        {
            this.screentip = screentip;
            return this;
        }
    }
}