//Problem 11. Version attribute

//Create a [Version] attribute that can be applied to structures, classes, interfaces,
//enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
//Apply the version attribute to a sample class and display its version at runtime.


using System;
namespace VersionAttribute
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct |
    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    class Versions : Attribute
    {
        public enum ComponentType
        {
            Class,
            Struct,
            Iterface,
            Enum,
            Method
        }
        private string minorVersion = string.Empty;
        private string majorVersion = string.Empty;
        private string componentName = string.Empty;
        private ComponentType currentType;

        public Versions(ComponentType component, string name, string version)
        {
            string[] temp = version.Split(new char[] { '.' });
            this.Component = component;
            this.Name = name;
            this.MajorVersion = temp[0];
            this.MinorVersion = temp[1];
        }

        public string MajorVersion
        {
            get
            {
                return this.majorVersion;
            }
            set
            {
                this.majorVersion = value;
            }
        }
        public string MinorVersion
        {
            get
            {
                return this.minorVersion;
            }
            set
            {
                this.minorVersion = value;
            }
        }

        public string Name
        {
            get
            {
                return this.componentName;
            }
            set
            {
                this.componentName = value;
            }
        }

        public ComponentType Component
        {
            get
            {
                return this.currentType;
            }
            set
            {
                this.currentType = value;
            }
        }

    }
}
