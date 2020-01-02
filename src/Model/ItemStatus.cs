using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace BareBonesCRUDMicroservice.Model
{
    public abstract class ItemStatus : SmartEnum<ItemStatus>
    {
        public static readonly ItemStatus New = new NewStatus();
        public static readonly ItemStatus Accepted = new AcceptedStatus();
        public static readonly ItemStatus Rejected = new RejectedStatus();
        public static readonly ItemStatus Deleted = new DeletedStatus();

        private ItemStatus(string name, int value) : base(name, value)
        {
        }

        public abstract bool CanTransitionTo(ItemStatus nextStatus);

        private sealed class NewStatus : ItemStatus
        {
            public NewStatus() : base("New", 0)
            {
            }

            public override bool CanTransitionTo(ItemStatus nextStatus) =>
                nextStatus == ItemStatus.Accepted || nextStatus == ItemStatus.Deleted;
        }

        private sealed class AcceptedStatus : ItemStatus
        {
            public AcceptedStatus() : base("Accepted", 1)
            {
            }

            public override bool CanTransitionTo(ItemStatus nextStatus) =>
                nextStatus == ItemStatus.Rejected || nextStatus == ItemStatus.Deleted;
        }

        private sealed class RejectedStatus : ItemStatus
        {
            public RejectedStatus() : base("Rejected", 2)
            {
            }

            public override bool CanTransitionTo(ItemStatus nextStatus) =>
                nextStatus == ItemStatus.Deleted;
        }

        private sealed class DeletedStatus : ItemStatus
        {
            public DeletedStatus() : base("Deleted", 3)
            {
            }

            public override bool CanTransitionTo(ItemStatus next) =>
                false;
        }
    }
}
