using Xunit;
using System;
using StackService.Library;

namespace StackService.Tests;

public class CustomStackTest
{
    [Fact]
    public void canPopEmptyStack()
    {
        var myStack = new CustomStack(10);
        Assert.Equal(null, myStack.pop());
    }

    [Fact]
    public void cantPushNullItem()
    {
        var myStack = new CustomStack(10);
        Assert.Throws<Exception>(()=> {
            myStack.push(null);
        });
    }
    
    [Fact]
    public void canPopSingleItem()
    {
        var myStack = new CustomStack(10);
        myStack.push("0");
        Assert.Equal("0", myStack.pop());
    }

    [Fact]
    public void canPopMultipleItems()
    {
        var myStack = new CustomStack(10);
        myStack.push("1");
        myStack.push("2");
        myStack.push("3");
        Assert.Equal("3", myStack.pop());
        Assert.Equal("2", myStack.pop());
        Assert.Equal("1", myStack.pop());
    }

    [Fact]
    public void cantPushTooManyItems()
    {
        var myStack = new CustomStack(2);
        myStack.push("1");
        myStack.push("2");
        Assert.Throws<Exception>(()=> {
            myStack.push("3");
        });
    }
    
}