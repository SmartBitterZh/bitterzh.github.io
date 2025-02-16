﻿using System;
using System.Security.Principal;
using YYT.Serialization;
using System.Collections.Generic;
using YYT.Core.FieldManager;
using System.Runtime.Serialization;
using YYT.Core;

namespace YYT.Security
{
  /// <summary>
  /// Provides a base class to simplify creation of
  /// a .NET identity object for use with BusinessPrincipalBase.
  /// </summary>
  public abstract partial class YYTIdentity : ReadOnlyBase<YYTIdentity>, IIdentity
  {
    private static int _forceInit;

    #region Constructor

    /// <summary>
    /// Creates an instance of the object.
    /// </summary>
    protected YYTIdentity()
    {
      _forceInit = _forceInit + 0;
    }

    #endregion

    /// <summary>
    /// Invokes the data portal to get an instance of
    /// the identity object.
    /// </summary>
    /// <typeparam name="T">
    /// Type of the YYTIdentity subclass to retrieve.
    /// </typeparam>
    /// <param name="criteria">
    /// Object containing the user's credentials.
    /// </param>
    /// <returns></returns>
    public static T GetYYTIdentity<T>(object criteria) where T : YYTIdentity
    {
      return DataPortal.Fetch<T>(criteria);
    }

    /// <summary>
    /// Method called when the object is deserialized.
    /// </summary>
    /// <param name="context">Serialization context.</param>
    protected override void OnDeserialized(StreamingContext context)
    {
      _forceInit = 0;
      base.OnDeserialized(context);
    }
  }
}
