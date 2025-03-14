using Builder.Characters;

namespace Builder.Builders
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Enemy _enemy = new Enemy();
        private void _reset()
        {
            _enemy = new Enemy();
        }

        public Character Build()
        {
            Enemy enemy = _enemy;
            _reset();
            return enemy;
        }

        public ICharacterBuilder WithBodyType(BodyType bodyType)
        {
            _enemy.SetBodyType(bodyType);
            return this;
        }

        public ICharacterBuilder WithHair(HairType hairType)
        {
            _enemy.SetHairType(hairType);
            return this;
        }

        public ICharacterBuilder WithHeight(int height)
        {
            _enemy.SetHeight(height);
            return this;
        }

        public ICharacterBuilder WithEquippedItem(string equipmentID)
        {
            _enemy.EquipItem(equipmentID);
            return this;
        }

        public ICharacterBuilder WithInventoryItem(string itemID)
        {
            _enemy.AddInventoryItem(itemID);
            return this;
        }

        public ICharacterBuilder WithIntent(string intent)
        {
            _enemy.AddBadIntent(intent);
            return this;
        }
    }
}
