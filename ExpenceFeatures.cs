﻿using ExpenseTracker;

public class ExpenseFeatures
{
    private List<Expense> expenses = new List<Expense>();
    private int lastId = 0;

    public void AddExpense(Expense expense)
    {
        expense.Id = ++lastId;
        expenses.Add(expense);
    }

    public void EditExpense(int id, Expense updatedExpense)
    {
        for (int i = 0; i < expenses.Count; i++)
        {
            if (expenses[i].Id == id)
            {
                updatedExpense.Id = id;
                expenses[i] = updatedExpense;
                break;
            }
        }
    }

    public void DeleteExpense(int id)
    {
        for (int i = 0; i < expenses.Count; i++)
        {
            if (expenses[i].Id == id)
            {
                expenses.RemoveAt(i);
                break;
            }
        }
    }

    public List<Expense> GetExpenses()
    {
        return expenses;
    }

    public void LoadExpenses(List<Expense> loadedExpenses)
    {
        for (int i = 0; i < loadedExpenses.Count; i++)
        {
            expenses.Add(loadedExpenses[i]);
            if (loadedExpenses[i].Id > lastId)
            {
                lastId = loadedExpenses[i].Id;
            }
        }
    }
}