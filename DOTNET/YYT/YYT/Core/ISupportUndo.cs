using System;

namespace YYT.Core
{
  /// <summary>
  /// Define the common methods used by the UI to 
  /// interact with n-level undo.
  /// </summary>
  /// <remarks>
  /// This interface is designed to help UI framework
  /// developers interact with editable business objects.
  /// The YYT .NET editable base classes already
  /// implement this interface and the required n-level
  /// undo behaviors.
  /// </remarks>
  public interface ISupportUndo
  {
    /// <summary>
    /// Starts a nested edit on the object.
    /// </summary>
    void BeginEdit();
    /// <summary>
    /// Cancels the current edit process, restoring the object's state to
    /// its previous values.
    /// </summary>
    void CancelEdit();
    /// <summary>
    /// Commits the current edit process.
    /// </summary>
    void ApplyEdit();
  }
}
