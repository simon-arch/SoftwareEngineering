using Builder.Characters;

namespace Builder.Builders
{
    public class CharacterDirector
    {
        private ICharacterBuilder _builder;

        public CharacterDirector SetBuilder(ICharacterBuilder builder)
        {
            _builder = builder;
            return this;
        }

        public CharacterDirector(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public Character BuildImportantEnemy()
        {
            return _builder
                .WithHair(HairType.Normal)
                .WithBodyType(BodyType.Skinny)
                .WithHeight(170)
                .WithInventoryItem("potion_greater_mana")
                .WithEquippedItem("staff_vortex")
                .WithEquippedItem("robe_forbidden")
                .WithIntent("Burn the village")
                .Build();
        }

        public Character BuildImportantHero()
        {
            return _builder
                .WithHair(HairType.Short)
                .WithBodyType(BodyType.Buff)
                .WithHeight(187)
                .WithInventoryItem("potion_greater_healing")
                .WithEquippedItem("sword_exoblade")
                .WithEquippedItem("helmet_spectre")
                .WithIntent("Save the village")
                .Build();
        }
    }
}
