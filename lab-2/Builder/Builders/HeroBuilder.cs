using Builder.Characters;

namespace Builder.Builders
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Hero _hero = new Hero();
        private void _reset()
        {
            _hero = new Hero();
        }

        public Character Build()
        {
            Hero hero = _hero;
            _reset();
            return hero;
        }

        public ICharacterBuilder WithBodyType(BodyType bodyType)
        {
            _hero.SetBodyType(bodyType);
            return this;
        }

        public ICharacterBuilder WithHair(HairType hairType)
        {
            _hero.SetHairType(hairType);
            return this;
        }

        public ICharacterBuilder WithHeight(int height)
        {
            _hero.SetHeight(height);
            return this;
        }

        public ICharacterBuilder WithEquippedItem(string equipmentID)
        {
            _hero.EquipItem(equipmentID);
            return this;
        }

        public ICharacterBuilder WithInventoryItem(string itemID)
        {
            _hero.AddInventoryItem(itemID);
            return this;
        }

        public ICharacterBuilder WithIntent(string intent)
        {
            _hero.AddGoodIntent(intent);
            return this;
        }
    }
}
