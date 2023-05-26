namespace Assignment
{
    public class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        // Default Constructor of the TreasureChest class.
        // It sets the default values for the material, lock type, and loot quality fields.

        public TreasureChest()
        {
            _material = Material.Iron;
            _lockType = LockType.Expert;
            _lootQuality = LootQuality.Green;
        }

        // Document these methods with XML documentation

        public TreasureChest(State state) : this()
        {
            _state = state;
        }

        // Initializes a new instance of the TreasureChest class with the specified material, lock type, and loot quality.

        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }

        // This is called a getter
        public State GetState()
        {
            return _state;
        }

        public State Manipulate(Action action)
        {
            // Method to manipulate the state of the treasure chest based on the specified action.

            if (action == Action.Open) {
                Open();
            }
            return _state;
        }

        public void Unlock()
        {
            // Method to unlock the treasure chest.

            if (_state == State.Locked)
            {
                _state = State.Closed;
                Console.WriteLine("The chest has unlocked successfully");
            }
            else
            {
                
                Console.WriteLine("Invalid action: The chest is not locked.");
            }
        }

        public void Lock()
        {
            // Method to lock the treasure chest.

            if (_state == State.Closed)
            {
                _state = State.Locked;
                Console.WriteLine("The chest has locked successfully.");
            }
            else
            {

                Console.WriteLine("Invalid action: The chest is not closed.");
            }
        }

        public void Open()
        {
            // We should check if the chest is closed

            if (_state == State.Closed)
            {
                _state = State.Open;
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest is already open!");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be opened because it is locked.");
            }
        }

        public void Close()
        {
            // Method to close the treasure chest.

            if (_state == State.Open)
            {
                _state = State.Closed;
                Console.WriteLine("The chest has closed successfully.");
            }
            else
            {

                Console.WriteLine("Invalid action: The chest is not open.");
            }
        }

        public override string ToString()
        {
            // Overrides the ToString() method to provide a string representation of the treasure chest.
            // Returns a formatted string containing the state, material, lock type, and loot quality.

            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        private static void ConsoleHelper(string prop1, string prop2, string prop3)
        {
            // Displays the provided properties as numbered options in the console.

            Console.WriteLine($"Choose from the following properties.\n1.{prop1}\n2.{prop2}\n3.{prop3}");
        }

        // Eun representing the possible states of the treasure chest.
        public enum State { Open, Closed, Locked };

         // Eun representing the possible actions that can be performed on the treasure chest.
        public enum Action { Open, Close, Lock, Unlock };

        // Eun representing the possible materials of the treasure chest.
        public enum Material { Oak, RichMahogany, Iron };

        // Eun representing the possible lock type of the treasure chest.
        public enum LockType { Novice, Intermediate, Expert };

        // Eun representing the possible loot qualities of the treasure chest.
        public enum LootQuality { Grey, Green, Purple };
    }
}
