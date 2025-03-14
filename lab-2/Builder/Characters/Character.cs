using System.Text;

namespace Builder.Characters
{
    public abstract class Character
    {
        private BodyType _bodyType;
        private HairType _hairType;
        private int _height;
        private List<string> _equippedItems = new List<string>();
        private List<string> _inventoryItems = new List<string>();

        public BodyType SetBodyType(BodyType bodyType)
        {
            return _bodyType = bodyType;
        }

        public HairType SetHairType(HairType hairType)
        {
            return _hairType = hairType;
        }

        public int SetHeight(int height)
        {
            return _height = height;
        }

        public string EquipItem(string equipmentID)
        {
            _equippedItems.Add(equipmentID);
            return equipmentID;
        }

        public string AddInventoryItem(string itemID)
        {
            _inventoryItems.Add(itemID);
            return itemID;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"┌ Body Type: {_bodyType.ToString()}");
            sb.AppendLine($"│ Hair Type: {_hairType.ToString()}");
            sb.AppendLine($"│ Height: {_height}");
            sb.AppendLine($"│ Equipped Items: [{string.Join(", ", _equippedItems.ToArray())}]");
            sb.AppendLine($"└ Inventory Items: [{string.Join(", ", _inventoryItems.ToArray())}]");
            return sb.ToString();
        }
    }
}
