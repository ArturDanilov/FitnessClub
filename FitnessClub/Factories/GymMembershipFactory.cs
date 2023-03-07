using FitnessClub.Domain;

namespace FitnessClub.Factories
{
    //только походы в зал
    internal class GymMembershipFactory : MembershipFactory
    {
        //цена и описание принимаются через конструктор
        private readonly decimal _price;
        private readonly string _description;

        public GymMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        //реализация фабричного метода
        public override IMembership GetMembership() //обязаны вернуть абонимент реализующий интерфейс IMembership
        {
            //создаем абонимент походов в зал
            GymMembership membership = new(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
