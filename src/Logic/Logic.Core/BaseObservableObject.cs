﻿namespace devdeer.DoctorFlox
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Base class for all types which want to inform on property changes in form of certain events.
    /// </summary>
    public abstract class BaseObservableObject : INotifyPropertyChanged
    {
        #region events

        /// <inheritdoc />
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region methods

        /// <summary>
        /// Is called by Fody.PropertyChanged whenever the value of a property changed.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed the value.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}