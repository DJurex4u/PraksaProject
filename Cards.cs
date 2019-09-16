using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHP_Business_Card_App
{
    static class Cards
    {        
        private static List<BussinesCard> bussinesCardList;
        public static void AddNewCard(BussinesCard newCard) {
            if (bussinesCardList == null) {
                bussinesCardList = new List<BussinesCard>();
            }
            bussinesCardList.Add(newCard);
        }
        public static BussinesCard GetCard(int cardNumber) {
            if (bussinesCardList != null)
            {
                return bussinesCardList[cardNumber];
            }
            return null;
        }
        public static int NumOfCards(){
            return (bussinesCardList.Count()) ;
            }
        public static bool IsEmpty(){
            return (!bussinesCardList.Any());
        }

        public static List<BussinesCard> GetBussinesCardsObjectList() {
            return bussinesCardList;
        }
        public static List<string> GetListOfCreated() {
            List<string> createdCards = new List<string>();
            foreach (BussinesCard card in bussinesCardList) {
                string FirstLastName = card.FirstName + " " + card.LastName;
                createdCards.Add(FirstLastName);
            }      

            return createdCards;
                }
    }
}
