using FaceSkinBridge.Models.Abstraction;
using FaceSkinBridge.Models.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FaceSkinBridge.Presentation
{
    public partial class CreamChoiceForm : System.Web.UI.Page
    {
        protected List<Cream> Creams
        {
            get
            {
                return ViewState["Creams"] as List<Cream>;
            }
            set
            {
                ViewState["Creams"] = value;
            }
        }

        public TypeSkin TypeSkin
        {
            get
            {
                return ViewState["TypeSkin"] as TypeSkin;
            }
            set
            {
                ViewState["TypeSkin"] = value;
            }
        }

        string nameSpace = "FaceSkinBridge.Models.Implementation";

        public ColorSkin ColorSkin
        {
            get
            {
                return ViewState["ColorSkin"] as ColorSkin;
            }
            set
            {
                ViewState["ColorSkin"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Creams = CreamRepository.GetCreams();
                Wizard1.ActiveStepIndex = 0;
            }
        }       


        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {

            IChooseCream methodChoice = null;
            switch (e.CurrentStepIndex)
            {
                case 0:
                    methodChoice = new ChooseCreamByType(TypeSkin);
                    break;
                case 1:
                    methodChoice = new ChooseCreamByColor(ColorSkin);
                    break;
                default:
                    return;                    
            }

            Creams = methodChoice.GetSuitableCream(Creams);
            lblCreamName.Text = Creams.First<Cream>().Name;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameType = RadioButtonList1.Items[RadioButtonList1.SelectedIndex].Value;
            TypeSkin = (TypeSkin)Activator.CreateInstance(Type.GetType(nameSpace + "." + nameType));
        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameType = RadioButtonList2.Items[RadioButtonList2.SelectedIndex].Value;
            ColorSkin = (ColorSkin)Activator.CreateInstance(Type.GetType(nameSpace + "." + nameType));
        }
    }
}