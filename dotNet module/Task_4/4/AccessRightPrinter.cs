using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_4._4
{
  /// <summary>
  /// Тип прав.
  /// </summary>
  [Flags, Serializable]
  public enum AccessRights : byte
  {
    /// <summary>
    /// Просмотр.
    /// </summary>
    View = 1,

    /// <summary>
    /// Выполнение.
    /// </summary>
    Run = 2,

    /// <summary>
    /// Добавление.
    /// </summary>
    Add = 4,

    /// <summary>
    /// Изменение.
    /// </summary>
    Edit = 8,

    /// <summary>
    /// Утверждение.
    /// </summary>
    Ratify = 16,

    /// <summary>
    /// Удаление.
    /// </summary>
    Delete = 32,

    /// <summary>
    /// Нет доступа.
    /// </summary>
    /// <remarks>
    /// Этот флаг имеет максимальный приоритет.
    /// Если он установлен, остальные флаги игнорируются 
    /// </remarks>
    AccessDenied = 64
  }

  /// <summary>
  /// Класс для вывода разрешенных действий
  /// </summary>
  public class AccessRightPrinter
  {
    /// <summary>
    /// Распечатать перечень действий, разрешенных правами
    /// </summary>
    /// <param name="accessRight">Тип прав</param>
    public void PrintAllowedAction(AccessRights accessRight)
    {
      if (accessRight.HasFlag(AccessRights.AccessDenied))
      {
        Console.WriteLine(AccessRights.AccessDenied);
        return;
      }

      IEnumerable<AccessRights> allowedRights = Enum.GetValues(typeof(AccessRights))
                                                      .Cast<AccessRights>()
                                                      .Where(a => accessRight >= a);

      foreach (var accRight in allowedRights)
        Console.WriteLine(accRight);
    }
  }
}
