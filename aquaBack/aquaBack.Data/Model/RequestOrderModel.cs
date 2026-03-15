using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aquaBack.Data.Model;

[Table("request_order")]
public class RequestOrderModel
{
    /*===============================================*/
    [Key] [Column("id")]
    public int RequestOrderId { get; set; }
    /*===============================================*/
    [Column("name_customer")] 
    public string NameCustomer { get; set; } = "";
    /*===============================================*/
    [Column("mail_customer")]
    public string MailCustomer { get; set; } = "";
    /*===============================================*/
    [Column("phone_num_customer")]
    public string PhoneNumCustomer { get; set; } = "";
    /*===============================================*/
}