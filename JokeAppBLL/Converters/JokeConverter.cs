using System;
using JokeAppBLL.BusinessObjects;
using JokeAppDAL.Entities;

namespace JokeAppBLL.Converters
{
    public class JokeConverter : IConverter<Joke, JokeBO>
    {
        public Joke Convert(JokeBO joke)
        {
            if(joke==null){
                return null;
            }
            return new Joke()
            {
                Id = joke.Id,
                Text = joke.Text,
                Funny = joke.Funny
            };
        }

        public JokeBO Convert(Joke joke)
        {
            if (joke == null)
            {
                return null;
            }

            return new JokeBO()
            {
                Id = joke.Id,
                Text = joke.Text,
                Funny = joke.Funny
            };
        }
    }
}
