using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using MySmartLockNamespace; 

namespace SmartLockTests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestLockInitialization()
        {
            
            var lockSystem = new SmartLock();  

            
            var result = lockSystem.IsLocked;

           
            Assert.IsFalse(result, "The lock should be initially unlocked.");
        }

        
        [TestMethod]
        public void TestLockSystem()
        {
          
            var lockSystem = new SmartLock();  

            
            lockSystem.Lock();  
            var result = lockSystem.IsLocked;

            
            Assert.IsTrue(result, "The lock should be locked after calling Lock().");
        }

        
        [TestMethod]
        public void TestUnlockSystem()
        {
            
            var lockSystem = new SmartLock();  
            lockSystem.Lock();  

           
            lockSystem.Unlock();  
            var result = lockSystem.IsLocked;

            
            Assert.IsFalse(result, "The lock should be unlocked after calling Unlock().");
        }
    }
}
