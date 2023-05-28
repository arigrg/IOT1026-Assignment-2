using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void OpenLockedTest()
        {
            // Chest starts in the locked state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            // Try to open the chest
            // Verify chest is still locked
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }

        [TestMethod]
        public void OpenClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }

        [TestMethod]
        public void OpenOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }

        private class TestClassAttribute : Attribute
        {
        }

        private class TestMethodAttribute : Attribute
        {
        }

         public void LockUnlockTest()
        {
            // Create a new chest and lock it
            TreasureChest chest = new TreasureChest();
            chest.Lock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);

            // Unlock the chest
            chest.Unlock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);
        }

        [TestMethod]
        public void CloseOpenTest()
        {
            // Create a new chest and open it
            TreasureChest chest = new TreasureChest();
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);

            // Close the chest
            chest.Close();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);
        }

        [TestMethod]
        public void ManipulateTest()
        {
            // Create a new chest and perform a series of actions
            TreasureChest chest = new TreasureChest();
            chest.Manipulate(TreasureChest.Action.Open);
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);

            chest.Manipulate(TreasureChest.Action.Close);
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);

            chest.Manipulate(TreasureChest.Action.Lock);
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);

            chest.Manipulate(TreasureChest.Action.Unlock);
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);
        }

        [TestMethod]
        public void InitializeWithCustomParametersTest()
        {
            // Create a new chest with custom material, lock type, and loot quality
            TreasureChest chest = new TreasureChest(
                TreasureChest.Material.Oak,
                TreasureChest.LockType.Novice,
                TreasureChest.LootQuality.Grey
            );

            // Verify that the chest is initialized with the specified values
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
            Assert.AreEqual(chest.ToString(), "A Locked chest with the following properties:\nMaterial: Oak\nLock Type: Novice\nLoot Quality: Grey");
        }
    }
}

       