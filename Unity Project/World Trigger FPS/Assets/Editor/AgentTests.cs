using NUnit.Framework;
using UnityEngine;
using FPS.Game;

namespace Tests
{
    public class AgentTests
    {
        [Test]
        public void MoveForwardOneWithVector3()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Vector3 Direction = Vector3.zero + Movement.Front;
            controller.Move(Direction);

            Assert.AreEqual(1, agent.Position.z);
        }

        [Test]
        public void MoveBackwardOneWithVector3()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Vector3 Direction = Vector3.zero + Movement.Back;
            controller.Move(Direction);

            Assert.AreEqual(-1, agent.Position.z);
        }

        [Test]
        public void MoveLeftOneWithVector3()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Vector3 Direction = Vector3.zero + Movement.Left;
            controller.Move(Direction);

            Assert.AreEqual(-1, agent.Position.x);
        }

        [Test]
        public void MoveRightOneWithVector3()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Vector3 Direction = Vector3.zero + Movement.Right;
            controller.Move(Direction);

            Assert.AreEqual(1, agent.Position.x);
        }

        [Test]
        public void MoveFallOneWithVector3()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Vector3 Direction = Vector3.zero + Movement.Down;
            controller.Move(Direction);

            Assert.AreEqual(-1, agent.Position.y);
        }

        [Test]
        public void MoveRiseOneWithVector3()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Vector3 Direction = Vector3.zero + Movement.Up;
            controller.Move(Direction);

            Assert.AreEqual(1, agent.Position.y);
        }

        [Test]
        public void MoveForwardOneWithMovement()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Movement Direction = Movement.Front;
            controller.Move(Direction);

            Assert.AreEqual(1, agent.Position.z);
        }

        [Test]
        public void MoveBackwardOneWithMovement()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Movement Direction = Movement.Back;
            controller.Move(Direction);

            Assert.AreEqual(-1, agent.Position.z);
        }

        [Test]
        public void MoveLeftOneWithMovement()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Movement Direction = Movement.Left;
            controller.Move(Direction);

            Assert.AreEqual(-1, agent.Position.x);
        }

        [Test]
        public void MoveRightOneWithMovement()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Movement Direction = Movement.Right;
            controller.Move(Direction);

            Assert.AreEqual(1, agent.Position.x);
        }

        [Test]
        public void MoveRiseOneWithMovement()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Movement Direction = Movement.Up;
            controller.Move(Direction);

            Assert.AreEqual(1, agent.Position.y);
        }

        [Test]
        public void MoveFallOneWithMovement()
        {
            IAgent agent = new MockAgent() { MaxMovementSpeed = Movement.One, Position = Vector3.zero };
            AgentController controller = new AgentController(agent);
            Movement Direction = Movement.Down;
            controller.Move(Direction);

            Assert.AreEqual(-1, agent.Position.y);
        }

        [Test]
        public void RotateUpOneWithRotation()
        {
            IAgent agent = new MockAgent() { MaxRotationSpeed = Rotation.One, Rotation = Quaternion.identity };
            AgentController controller = new AgentController(agent);
            Rotation Rotate = Rotation.Up;
            controller.Rotate(Rotate);

            Assert.AreEqual(1, agent.Rotation.eulerAngles.x);
        }

        [Test]
        public void RotateDownOneWithRotation()
        {
            IAgent agent = new MockAgent() { MaxRotationSpeed = Rotation.One, Rotation = Quaternion.identity };
            AgentController controller = new AgentController(agent);
            Rotation Rotate = Rotation.Down;
            controller.Rotate(Rotate);

            Assert.AreEqual(359, agent.Rotation.eulerAngles.x);
        }

        [Test]
        public void RotateLeftOneWithRotation()
        {
            IAgent agent = new MockAgent() { MaxRotationSpeed = Rotation.One, Rotation = Quaternion.identity };
            AgentController controller = new AgentController(agent);
            Rotation Rotate = Rotation.Left;
            controller.Rotate(Rotate);

            Assert.AreEqual(359, agent.Rotation.eulerAngles.y);
        }

        [Test]
        public void RotateRightOneWithRotation()
        {
            IAgent agent = new MockAgent() { MaxRotationSpeed = Rotation.One, Rotation = Quaternion.identity };
            AgentController controller = new AgentController(agent);
            Rotation Rotate = Rotation.Right;
            controller.Rotate(Rotate);

            Assert.AreEqual(1, agent.Rotation.eulerAngles.y);
        }

        [Test]
        public void RotateRollRightOneWithRotation()
        {
            IAgent agent = new MockAgent() { MaxRotationSpeed = Rotation.One, Rotation = Quaternion.identity };
            AgentController controller = new AgentController(agent);
            Rotation Rotate = Rotation.RollRight;
            controller.Rotate(Rotate);

            Assert.AreEqual(1, agent.Rotation.eulerAngles.z);
        }

        [Test]
        public void RotateRollLeftOneWithRotation()
        {
            IAgent agent = new MockAgent() { MaxRotationSpeed = Rotation.One, Rotation = Quaternion.identity };
            AgentController controller = new AgentController(agent);
            Rotation Rotate = Rotation.RollLeft;
            controller.Rotate(Rotate);

            Assert.AreEqual(359, agent.Rotation.eulerAngles.z);
        }
    }
}
