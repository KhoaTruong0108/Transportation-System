using System;
using System.Data.Objects.DataClasses;
using DBManagement;

/// <summary>
/// The Entity namespace.
/// </summary>
namespace AppCommon.Entity
{
    /// <summary>
    /// Class OrderBase.
    /// </summary>
    public class OrderBase : EntityObject
    {
        /// <summary>
        /// The id
        /// </summary>
        private string _id;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <quantity>The identifier.</quantity>
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// The _total_quantity
        /// </summary>
        private int _total_quantity;

        /// <summary>
        /// Gets or sets the total_quantity.
        /// </summary>
        /// <quantity>The total_quantity.</quantity>
        public int total_quantity
        {
            get { return _total_quantity; }
            set { _total_quantity = value; }
        }

        /// <summary>
        /// The _total_value
        /// </summary>
        private decimal _total_value;

        /// <summary>
        /// Gets or sets the total_value.
        /// </summary>
        /// <quantity>The total_value.</quantity>
        public decimal total_value
        {
            get { return _total_value; }
            set { _total_value = value; }
        }

        /// <summary>
        /// The _total_cost
        /// </summary>
        private decimal _total_cost;

        /// <summary>
        /// Gets or sets the total_cost.
        /// </summary>
        /// <quantity>The total_cost.</quantity>
        public decimal total_cost
        {
            get { return _total_cost; }
            set { _total_cost = value; }
        }

        /// <summary>
        /// The _order_status
        /// </summary>
        private string _order_status;

        /// <summary>
        /// Gets or sets the order_status.
        /// </summary>
        /// <quantity>The order_status.</quantity>
        public string order_status
        {
            get { return _order_status; }
            set { _order_status = value; }
        }

        /// <summary>
        /// The _payment_status
        /// </summary>
        private string _payment_status;

        /// <summary>
        /// Gets or sets a quantity indicating whether this <see cref="OrderBase"/> is payment_status.
        /// </summary>
        /// <quantity><c>true</c> if payment_status; otherwise, <c>false</c>.</quantity>
        public string payment_status
        {
            get { return _payment_status; }
            set { _payment_status = value; }
        }

        /// <summary>
        /// The _destination
        /// </summary>
        private string _tour_id;

        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        /// <value>The destination.</value>
        public string tour_id
        {
            get { return _tour_id; }
            set { _tour_id = value; }
        }

        /// <summary>
        /// The _created_date
        /// </summary>
        private DateTime _created_date;

        /// <summary>
        /// Gets or sets the created_date.
        /// </summary>
        /// <quantity>The created_date.</quantity>
        public DateTime created_date
        {
            get { return _created_date; }
            set { _created_date = value; }
        }

        /// <summary>
        /// The _created_by
        /// </summary>
        private string _created_by;

        /// <summary>
        /// Gets or sets the created_by.
        /// </summary>
        /// <quantity>The created_by.</quantity>
        public string created_by
        {
            get { return _created_by; }
            set { _created_by = value; }
        }

        /// <summary>
        /// The _closed_date
        /// </summary>
        private DateTime? _closed_date;

        /// <summary>
        /// Gets or sets the closed_date.
        /// </summary>
        /// <quantity>The closed_date.</quantity>
        public DateTime? closed_date
        {
            get { return _closed_date; }
            set { _closed_date = value; }
        }

        public OrderBase()
        {
        }

        /// <summary>
        /// Converts to regular order.
        /// </summary>
        /// <returns>IrregularOrder.</returns>
        public IrregularOrder ToIrregular()
        {
            IrregularOrder irregularOrder = new IrregularOrder();
            irregularOrder.id = this.id;
            irregularOrder.order_status = this.order_status;
            irregularOrder.payment_status = this.payment_status;
            irregularOrder.tour_id = this.tour_id;
            irregularOrder.total_quantity = this.total_quantity;
            irregularOrder.total_value = this.total_value;
            irregularOrder.total_cost = this.total_cost;
            irregularOrder.created_date = this.created_date;
            irregularOrder.created_by = this.created_by;
            irregularOrder.closed_date = this.closed_date;
            irregularOrder.confirmation_user_id = string.Empty;
            return irregularOrder;
        }

        /// <summary>
        /// Converts to regular order.
        /// </summary>
        /// <returns>RegularOrder.</returns>
        public RegularOrder ToRegular()
        {
            RegularOrder regularOrder = new RegularOrder();
            regularOrder.id = this.id;
            regularOrder.order_status = this.order_status;
            regularOrder.payment_status = this.payment_status;
            regularOrder.tour_id = this.tour_id;
            regularOrder.total_quantity = this.total_quantity;
            regularOrder.total_value = this.total_value;
            regularOrder.total_cost = this.total_cost;
            regularOrder.created_date = this.created_date;
            regularOrder.created_by = this.created_by;
            regularOrder.closed_date = this.closed_date;
            return regularOrder;
        }
    }
}
