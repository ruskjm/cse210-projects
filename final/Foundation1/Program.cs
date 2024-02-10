//The Program class serves as the entry point for the application.
class Program {

    // Entry point for application
    static void Main(string[] args) {

        // List for the video title, author, length and each user and comment
        List<string> videoData = new List<string>() {
            "Title:Quarterback Conversations with Steve Young and Brock Purdy",
            "Author:49ers", 
            "Length:1543",
            "patricklacson",
            "Steve Young genuinely likes Brock and impressed by his humility and grounding in his faith and family. " +
            "Great interview!",   
            "boonejune",
            "Steve Young is a treasure, thoughtful, highly engaged and doesn't interrupt his guests. " +
            "Brock has all the intangibles to bring home a championship!",
            "steve0mcmurray",
            "The world needs more people with this level of humility.",
            "Tandez_Academy",
            "Brock Purdy is a true man of faith. Humble, grounded, and always respectful. God will take this " +
            "man to the highest of highs! Super Bowl MVP!",
            "63hunter1",
            "I've been a 49er loyal since the late 70's and I couldn't be more proud to be a 49er faithful. " +
            "Go Niners!!! Thank you guys.",
            "Title:Be Kind to Yourself, Beloved Child of God",
            "Author:The Church of Jesus Christ of Latter-day Saints",
            "Length:381", 
            "baileyarmour6132",
            "This is a beautiful testimony. The artwork is stunning. I'm grateful to Tyran for his vulnerability " +
            "and for sharing his talent.",
            "ethanseely1898",
            "I love this message! We are all children of God, and he loves us, and wants us to love ourselves.",
            "EricHansenHaiTech",
            "Treat yourself the way Jesus would treat you: with honesty, compassion, " +
            "and an eye toward your eternal potential.",
            "Title:C# Tutorial For Beginners - Learn C# Basics in 1 Hour",
            "Author:Programming with Mosh",
            "Length:3692",
            "emo10001",
            "Wow this is fantastic.  I've started and not finished a LOT of C++ and C# tutorials.  I have no " +
            "doubt that I will finish this and many of your other course offerings.  This is exactly what a beginner " +
            "needs.  I can't wait to watch more.",
            "gem8273",
            "It was the best lecture I’ve ever seen so far. Also, your accent is really clear for someone like me " +
            "who is not native English is smooth and understandable. I appreciate it thanks.",
            "imedsalah7343",
            "I had never seen clear and simple programming course like this!",
            "pecanthejelly5854",
            "I learned more from this tutorial than I did in 12 weeks of a programming college course.",
            "Title:Think Celestial!",
            "Author:Russell M. Nelson",
            "Length:1155",
			"cyndipodell1498",
			"I am not a member of the church but I love to listen to pres. nelson. he gives me peace. I pray " +
            "for his recovery!",
			"ChaLifeCoach",
			"I am a Seventh-Day Adventist Christian but I love President Nelson’s message. He is so blessed and " +
            "humble May the good LORD continue blessing him. The message is powerful.",
			"user-cl4gp6ju3m",
			"This is the first general conference I have ever watched and I feel like his message is so relevant " +
            "to my life right now. Thank you so much!",
			"841577",
			"This is the most powerful talk I have ever heard. This man is truly a prophet of God.",
			"michaelvitta5577",
			"This really hits home, I am so blessed to have found the restored gospel 2 years ago."
        };

        // Create null object
        Video video = null;

        // Look thru the list to populate video properties
        for(int i=0; i<videoData.Count; i++) {

            // If the value in index equals Title
            if(videoData[i].StartsWith("Title")) {

                // Display previous video
                if (video != null) {

                    // Call the DisplayVideoInfo method in Video class
                    video.DisplayVideoInfo();

                    // Loop thru each comment
                    foreach (var comment in video._comments) {

                        // Call the DisplayComments method in Comment class
                        comment.DisplayComments();
                    } 
                }

                // Create new Video instance 
                video = new Video();  

                // Clear comments for new video
                video._comments.Clear();

                // Set the _title variable
                video._title = videoData[i].Split(':')[1];
            }

            // If the value in index equals Author
            else if(videoData[i].StartsWith("Author")) {

                // Set the _author variable
                video._author = videoData[i].Split(':')[1]; 
            }

            // If the value in index equals Length
            else if(videoData[i].StartsWith("Length")) {

                // Set the _length variable
                video._length = videoData[i].Split(':')[1]; 
            }

            // Alternate lines are comments
            else {  
                // Add to the comments lists
                video._comments.Add(new Comment{

                    // Set the _name variable
                    _name = videoData[i],

                    // Set the _comment variable
                    _comment = videoData[i+1] 
                });
                
                // Skip next line  
                i++; 
            }  
        }

        // Display last video
        if (video != null) {

            // Call the DisplayVideoInfo method in Video class
            video.DisplayVideoInfo();

            // Loop thru each comment
            foreach (var comment in video._comments) {

                // Call the DisplayComments method in Comment class
                    comment.DisplayComments();
            } 
        }     
    }
}