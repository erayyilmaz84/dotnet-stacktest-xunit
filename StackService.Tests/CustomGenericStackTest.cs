using Xunit;
using System;
using StackService.Library;

namespace StackService.Tests;

public class CustomGenericStackTest
{
    [Fact]
    public void canPopEmptyStack()
    {
        var myStack = new CustomGenericStack<string>();
        Assert.Equal(null, myStack.pop());
    }

    [Fact]
    public void canPopSingleItem()
    {
        var myStack = new CustomGenericStack<string>();
        myStack.push("0");
        Assert.Equal("0", myStack.pop());
    }

    [Fact]
    public void canPopMultipleItems()
    {
        var myStack = new CustomGenericStack<string>()
        .push("1")
        .push("2")
        .push("3");

        Assert.Equal("3", myStack.pop());
        Assert.Equal("2", myStack.pop());
        Assert.Equal("1", myStack.pop());

    }


}