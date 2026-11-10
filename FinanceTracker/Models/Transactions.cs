using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace FinanceTracker.Models;

public class Transaction
{
    public int Id { get; set; }
    public decimal Amount { get; set; } //сумма
    public DateTime Date { get; set; } = DateTime.Now;
    public string? Comment { get; set; }//комментарий к транзакции

    public int CategoryId { get; set; }//внешний ключ
    public Category? Category { get; set; }
}