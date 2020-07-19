# Speech-to-Indian-Sign-Language-translation-System
Built a mobile application that converts Speech to Indian Sign Language using Native Android on Unity.
Takes speech as input and converts it into text which is then parsed to map text to corresponding Sign Language gestures visualized using a 3D avatar.

Flow of Project:
Convert English speech to text using Google Speech-to-Text API. 
We generated animated Hand Gestures using Kinect 360 and MikuMikuDance for a vocabulary of words.
Stopwords eliminated from the given input string as such words do not have sign gestures
Mapped text to correspong hand gestures maintaining the logical flow of sentence
ISL interpretation achieved with a success rate of 78% by developing a 3D avatar to visually enhance ISL presentation.
