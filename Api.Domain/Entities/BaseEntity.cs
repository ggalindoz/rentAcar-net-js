using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public abstract class BaseEntity
    {
        private DateTime? _createAt;
        private DateTime? updateAt;

        [Key]
        public Guid Id { get; set; }
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get => updateAt; set => updateAt = value; }

        // public DateTime? getCreatAt(){
        //     return _createAt;
        // }

        // public void setCreatAt(DateTime value){
        //      _createAt = (value == null ? DateTime.UtcNow : value);
        // }
    }

}
