using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apex.MVVM;
namespace Solitare
{
    class PlayingCards : ViewModel
    {

        public Suit Suit
        {
            get
            {
                int cardValue = Convert.ToInt32(Type);
                if (cardValue < 13)
                {
                    return Suit.Hearts;
                }
                else if (cardValue > 13 && cardValue < 26)
                {
                    return Suit.Diamonds;
                }
                else if (cardValue > 26 && cardValue < 39)
                {
                    return Suit.Clubs;
                }
                else
                {
                    return Suit.Spades;
                }
            }

        }

        public int Value
        {
            get
            {
                return (Convert.ToInt32(Type)) % 13;
            }
        }
        public Color Color
        {
            get
            {
                return (Convert.ToInt32(Type)) < 26 ?
                    Color.Red : Color.Black;
            }
        }
        private INotifyPropertyChanged TypeProperty =
            new INotifyPropertyChanged("Type", typeof(Type), Type.SpadesA);
       
        public Type Type
        {
            get { return (Type)GetValue(TypeProperty)}
            set { SetValue(TypeProperty,value)}

        }
    }
}
