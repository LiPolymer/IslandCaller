﻿using CommunityToolkit.Mvvm.ComponentModel;
using IslandCaller.Views.Windows;

namespace IslandCaller.Models;

public class Settings : ObservableRecipient
{
    private bool _isHoverShow = true;

    public bool IsHoverShow
    {
        get => _isHoverShow;
        set
        {
            if (value == _isHoverShow) return;
            _isHoverShow = value;
            OnPropertyChanged();
        }
    }

    bool _isBreakProofEnabled;
    public bool IsBreakProofEnabled
    {
        get => _isBreakProofEnabled;
        set
        {
            if (value == _isBreakProofEnabled) return;
            _isBreakProofEnabled = value;
            OnPropertyChanged();
        }
    }

    HoverPositionData _hoverPosition = new HoverPositionData
    {
        X = 500,
        Y = 300
    };
    public HoverPositionData HoverPosition
    {
        get => _hoverPosition;
        set
        {
            if (_hoverPosition.X.Equals(value.X) & _hoverPosition.Y.Equals(value.Y)) return;
            _hoverPosition = value;
            OnPropertyChanged();
        }
    }

    public class HoverPositionData : ObservableRecipient
    {
        double _x;
        public double X
        {
            get => _x;
            set
            {
                if (value.Equals(_x)) return;
                _x = value;
                OnPropertyChanged();
            }
        }

        double _y;
        public double Y
        {
            get => _y;
            set
            {
                if (value.Equals(_y)) return;
                _y = value;
                OnPropertyChanged();
            }
        }
    }
}