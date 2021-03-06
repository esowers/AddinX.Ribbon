﻿using System;
using System.Xml.Linq;
using AddinX.Ribbon.Contract.Control.ButtonUnsize;
using AddinX.Ribbon.Contract.Control.MenuUnsize;
using AddinX.Ribbon.Contract.Control.SplitButtonUnsize;
using AddinX.Ribbon.Contract.Control.ToggleButtonUnsize;
using AddinX.Ribbon.Contract.Enums;
using AddinX.Ribbon.Implementation.Ribbon;

namespace AddinX.Ribbon.Implementation.Control
{
    public class SplitButtonUnsize : Control, ISplitButtonUnsize
    {
        private string supertip;
        private string screentip;
        private string keytip;
        private string description;

        private readonly ISplitButtonUnsizeControls controls;

        public SplitButtonUnsize()
        {
            ElementName = "splitButton";
            Id = new ElementId();
            controls = new Controls();
        }

        protected internal ISplitButtonUnsizeId SetLabel(string value)
        {
            Label = value;
            return this;
        }

        public ISplitButtonUnsizeExtra Description(string description)
        {
            this.description = description;
            return this;
        }

        public ISplitButtonUnsizeExtra Supertip(string supertip)
        {
            this.supertip = supertip;
            return this;
        }

        public ISplitButtonUnsizeExtra Keytip(string keytip)
        {
            this.keytip = keytip;
            return this;
        }

        public ISplitButtonUnsizeExtra Screentip(string screentip)
        {
            this.screentip = screentip;
            return this;
        }

        public ISplitButtonUnsizeButton SetId(string name)
        {
            Id.SetId(name);
            return this;
        }

        public ISplitButtonUnsizeButton SetIdMso(string name)
        {
            Id.SetMicrosoftId(name);
            return this;
        }

        public ISplitButtonUnsizeButton SetIdQ(string ns, string name)
        {
            Id.SetNamespaceId(ns, name);
            return this;
        }
        
        public ISplitButtonUnsizeMenu AddButton(string label, Action<IButtonUnsizeId> button)
        {
            var control = controls.AddButton(label);
            button(control);
            return this;
        }

        public ISplitButtonUnsizeMenu AddToggleButton(string label, Action<IToggleButtonUnsizeId> toggleButton)
        {
            var control = controls.AddToggleButton(label);
            toggleButton(control);
            return this;
        }

        public ISplitButtonUnsizeExtra AddMenu(string label, Action<IMenuUnsizeId> menu)
        {
            var control = controls.AddMenu(label);
            menu(control);
            return this;
        }

        protected internal override XElement ToXml(XNamespace ns)
        {
            var tmpId = (ElementId)Id;

            var element = new XElement(ns + ElementName
                , new XAttribute(tmpId.Type.ToString(), tmpId.Value)
                , new XAttribute("getEnabled", "GetEnabled")
                , new XAttribute("getVisible", "GetVisible")
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

            if (((AddInList)controls)?.ToXml(ns) != null)
            {
                element.Add(((AddInList)controls).ToXml(ns));
            }

            return element;
        }
    }
}