// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListOfListWithRowsAsUserInputExample.xaml.cs" company="PropertyTools">
//   Copyright (c) 2014 PropertyTools contributors
// </copyright>
// <summary>
//   Interaction logic for ListOfListWithRowsAsUserInputs.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataGridDemo;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

public partial class ListOfListWithRowsAsUserInputExample : INotifyPropertyChanged
{
    private int rowCount;

    private List<ObservableCollection<string>> itemsSource;

    public ListOfListWithRowsAsUserInputExample()
    {
        this.InitializeComponent();

        this.ItemsSource = [];
        this.CreateRowsCommand = new RelayCommand(CreateRows);

        this.DataContext = this;
    }

    public bool RefreshView => true;

    public ICommand CreateRowsCommand { get; }

    public int RowCount
    {
        get => this.rowCount;
        set
        {
            this.rowCount = value;
            OnPropertyChanged(nameof(RowCount));
        }
    }

    public List<ObservableCollection<string>> ItemsSource
    {
        get => this.itemsSource;
        set
        {
            this.itemsSource = value;
            OnPropertyChanged(nameof(ItemsSource));
        }
    }

    private void CreateRows()
    {
        for (var i = 0; i < RowCount; i++)
        {
            var row = new ObservableCollection<string> { $"Row {i + 1} - A", $"Row {i + 1} - B", $"Row {i + 1} - C" };
            this.ItemsSource.Add(row);
        }

        this.OnPropertyChanged(nameof(RefreshView));
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class RelayCommand(Action execute, Func<bool> canExecute = null) : ICommand
{
    public bool CanExecute(object parameter) => canExecute == null || canExecute();

    public void Execute(object parameter) => execute();

    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}