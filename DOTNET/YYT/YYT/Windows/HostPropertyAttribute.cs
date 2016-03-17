﻿using System;

namespace YYT.Windows
{
  /// <summary>
  /// HostPropertyAttribute is used on components to 
  /// indicate the property on the component that is to be used as the 
  /// parent container control in conjunction with HostComponentDesigner.
  /// </summary>
  public class HostPropertyAttribute : Attribute
  {

    #region Property Fields

    private string _hostPropertyName = string.Empty;

    #endregion

    #region Properties

    /// <summary>
    /// HostPropertyName gets the host property name.
    /// </summary>
    public string HostPropertyName
    {
      get { return (_hostPropertyName); }
    }

    #endregion

    #region Constructors

    /// <summary>
    /// Constructor creates a new HostPropertyAttribute object instance using the information supplied.
    /// </summary>
    /// <param name="hostPropertyName">The name of the host property.</param>
    public HostPropertyAttribute(string hostPropertyName)
    {
      _hostPropertyName = hostPropertyName;
    }

    #endregion

  }
}