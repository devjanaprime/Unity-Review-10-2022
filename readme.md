Unity Review Project 2022
===

Have been focusing on Full Stack web stuff for the last month so wanted to touch base with Unity on some foundational stuff as a review.

Objectives/Key features:
---

- Review creation/use of Scriptable Objects
- Get data from web API (omdb)
- Load something from an Addressable Group
- Do something in the UI
- parse JSON data

This is going to be a really short review project to just get my feet back into things. I'm thinking it'll do the following:

1. On scene load, a script will make a GET call to OMDB using an apikey from the SO, then set a string on the SO to the response
2. parse JSON data, extract an array, & load an instance of an object from an Addressable Group for each movie in the array
3. Set the texture on each object to the appropriate movie poster
4. do something with the UI... not sure what yet