# ![cf](http://i.imgur.com/7v5ASc8.png) Lab 19 : Project Kickoff

## Midterm Project
- Refer to the Midterm folder in the Class repo for further instructions

# Assignments

## Coding Challenge

### Animal Game
In the animal game, the user thinks of an animal, and the program's simple artificial intelligence tries to guess what it is. The program is a learning system,
so over time it gets better at guesing the user's animal. 

The program stores the information in a tree, each internal node holds a yes or no question that guides the program down the left or right side of a  tree.
Each leaf node represents an animal. 

The program asks questions at each node and follows the appropriate branch until it reaches a leaf node where it guesses the node's animal. 

If the program is wrong, it asks:
1. What the animal was
2. The type a question to differentiate between the animal it guessed and the correct answer. 

It adds a new internal node contianing the question and give the node leaves holding the correct and incorrect animals. 

### Example: 1 (Correct Guess)
1. Is it a mammel? **No**
2. Does it have scales? **Yes**
3. Does it breathe water? **No**
4. Is it a snake? **Yes**


## Example 2 (Incorrect Guess)
1. Is it an animal? **Yes**
2. Does it bark? **No**
3. Is it a cat? **No**
4. What is your Animal? **Giraffe**
5. What question could I have asked to differentiate between a cat and a giraffe? **Does it have a long neck?**
6. Is the answer to this question true for a giraffe? **Yes**

View attached image in this folder as a guide

-Using your "data-structures" repository
  - add a folder and label it `Code Challenge exercises`
  - add the code on a branch from this challenge into this repo
  - Describe your approach in the strings folder readme document
  - Spend no more than 90 minutes on this challenge
  - Submit a link to your repo PR in canvas