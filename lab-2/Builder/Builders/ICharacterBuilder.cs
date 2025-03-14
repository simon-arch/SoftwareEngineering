using Builder.Characters;

namespace Builder.Builders
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder WithBodyType(BodyType bodyType);
        ICharacterBuilder WithHair(HairType hair);
        ICharacterBuilder WithHeight(int height);
        ICharacterBuilder WithEquippedItem(string equipmentID);
        ICharacterBuilder WithInventoryItem(string itemID);
        ICharacterBuilder WithIntent(string intent);
        Character Build();
    }
}
