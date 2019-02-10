﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleListView.Data;

namespace SimpleListView.Data.Migrations.Movie
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20190209170150_InitialConfig")]
    partial class InitialConfig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimpleListView.Models.Movie", b =>
                {
                    b.Property<string>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("BriefStory")
                        .HasMaxLength(4000);

                    b.Property<string>("Cast")
                        .HasMaxLength(200);

                    b.Property<string>("Category")
                        .HasMaxLength(50);

                    b.Property<string>("Director")
                        .HasMaxLength(100);

                    b.Property<int>("Duration");

                    b.Property<string>("Genre")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .HasMaxLength(200);

                    b.Property<int>("Year");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");

                    b.HasData(
                        new { MovieID = "M17-001", BriefStory = "Fueled by his restored faith in humanity and inspired by Superman's selfless act, Bruce Wayne enlists the help of his new-found ally, Diana Prince, to face an even greater enemy.", Cast = "Ben Affleck, Gal Gadot, Jason Momoa, Ezra Miller", Category = "PG-13", Director = "Zack Snyder", Duration = 120, Genre = "Action, Adventure, Fantasy", Title = "Justice League", Year = 2017 },
                        new { MovieID = "M17-002", BriefStory = "Thor is imprisoned on the planet Sakaar, and must race against time to return to Asgard and stop Ragnarök, the destruction of his world, at the hands of the powerful and ruthless villain Hela.", Cast = "Chris Hemsworth, Tom Hiddleston, Cate Blanchett, Mark Ruffalo", Category = "PG-13", Director = "Taika Waititi", Duration = 130, Genre = "Action, Adventure, Comedy", Title = "Thor: Ragnarok ", Year = 2017 },
                        new { MovieID = "M17-003", BriefStory = "Devoted lifeguard Mitch Buchannon butts heads with a brash new recruit, as they uncover a criminal plot that threatens the future of the bay.", Cast = "Dwayne Johnson, Zac Efron, Alexandra Daddario, Priyanka Chopra", Category = "R", Director = "Seth Gordon", Duration = 116, Genre = "Action, Comedy, Crime", Title = "Baywatch", Year = 2017 },
                        new { MovieID = "M17-004", BriefStory = "Peter Parker balances his life as an ordinary high school student in Queens with his superhero alter-ego Spider-Man, and finds himself on the trail of a new menace prowling the skies of New York City.", Cast = "Tom Holland, Michael Keaton, Robert Downey Jr., Marisa Tomei", Category = "PG-13", Director = "Jon Watts", Duration = 133, Genre = "Action, Adventure, Sci-Fi", Title = "Spider-Man: Homecoming", Year = 2017 },
                        new { MovieID = "M17-005", BriefStory = "When a pilot crashes and tells of conflict in the outside world, Diana, an Amazonian warrior in training, leaves home to fight a war, discovering her full powers and true destiny.", Cast = "Gal Gadot, Chris Pine, Robin Wright, Lucy Davis", Category = "PG-13", Director = "Patty Jenkins", Duration = 141, Genre = "Action, Adventure, Fantasy", Title = "Wonder Woman", Year = 2017 },
                        new { MovieID = "M17-006", BriefStory = "Rey develops her newly discovered abilities with the guidance of Luke Skywalker, who is unsettled by the strength of her powers. Meanwhile, the Resistance prepares for battle with the First Order.", Cast = "Daisy Ridley, John Boyega, Mark Hamill, Carrie Fisher", Category = "PG-13", Director = "Rian Johnson", Duration = 152, Genre = "Action, Adventure, Fantasy", Title = "Star Wars: Episode VIII - The Last Jedi", Year = 2017 },
                        new { MovieID = "M17-007", BriefStory = "The Guardians struggle to keep together as a team while dealing with their personal family issues, notably Star-Lord's encounter with his father the ambitious celestial being Ego.", Cast = "Chris Pratt, Zoe Saldana, Dave Bautista, Vin Diesel", Category = "PG-13", Director = "James Gunn", Duration = 136, Genre = "Action, Adventure, Comedy", Title = "Guardians of the Galaxy Vol. 2", Year = 2017 },
                        new { MovieID = "M17-008", BriefStory = "Xander Cage is left for dead after an incident, though he secretly returns to action for a new, tough assignment with his handler Augustus Gibbons.", Cast = "Vin Diesel, Donnie Yen, Deepika Padukone, Kris Wu", Category = "PG-13", Director = "D.J. Caruso", Duration = 107, Genre = "Action, Adventure, Thriller", Title = "xXx: Return of Xander Cage", Year = 2017 },
                        new { MovieID = "M17-009", BriefStory = "A selfish prince is cursed to become a monster for the rest of his life, unless he learns to fall in love with a beautiful young woman he keeps prisoner.", Cast = "Emma Watson, Dan Stevens, Luke Evans, Josh Gad", Category = "PG", Director = "Bill Condon", Duration = 129, Genre = "Family, Fantasy, Musical", Title = "Beauty and the Beast ", Year = 2017 },
                        new { MovieID = "M17-010", BriefStory = "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead to find his great-great-grandfather, a legendary singer.", Cast = "Anthony Gonzalez, Gael García Bernal, Benjamin Bratt, Alanna Ubach", Category = "PG", Director = "Lee Unkrich, Adrian Molina", Duration = 105, Genre = "Animation, Adventure, Comedy", Title = "Coco", Year = 2017 },
                        new { MovieID = "M17-011", BriefStory = "When a mysterious woman seduces Dom into the world of terrorism and a betrayal of those closest to him, the crew face trials that will test them as never before.", Cast = "Vin Diesel, Jason Statham, Dwayne Johnson, Michelle Rodriguez", Category = "PG-13", Director = "F. Gary Gray", Duration = 136, Genre = "Action, Crime, Thriller", Title = "The Fate of the Furious", Year = 2017 },
                        new { MovieID = "M17-012", BriefStory = "A team of scientists aboard the International Space Station discover a rapidly evolving life form that caused extinction on Mars and now threatens all life on Earth.", Cast = "Jake Gyllenhaal, Rebecca Ferguson, Ryan Reynolds, Hiroyuki Sanada", Category = "R", Director = "Daniel Espinosa", Duration = 104, Genre = "Horror, Sci-Fi, Thriller", Title = "Life", Year = 2017 },
                        new { MovieID = "M17-013", BriefStory = "Captain Jack Sparrow searches for the trident of Poseidon while being pursued by an undead sea captain and his crew.", Cast = "Johnny Depp, Geoffrey Rush, Javier Bardem, Orlando Bloom", Category = "PG-13", Director = "Joachim Rønning, Espen Sandberg", Duration = 129, Genre = "Action, Adventure, Fantasy", Title = "Pirates of the Caribbean: Dead Men Tell No Tales", Year = 2017 },
                        new { MovieID = "M17-014", BriefStory = "An ancient Egyptian princess is awakened from her crypt beneath the desert, bringing with her malevolence grown over millennia, and terrors that defy human comprehension.", Cast = "Tom Cruise, Sofia Boutella, Annabelle Wallis, Russell Crowe", Category = "PG-13", Director = "Alex Kurtzman", Duration = 110, Genre = "Action, Adventure, Fantasy", Title = "The Mummy", Year = 2017 },
                        new { MovieID = "M17-015", BriefStory = "A deadly threat from Earth's history reappears, and a hunt for a lost artifact takes place between Autobots and Decepticons, while Optimus Prime encounters his creator in space.", Cast = "Mark Wahlberg, Anthony Hopkins, Josh Duhamel, Laura Haddock", Category = "PG-13", Director = "Michael Bay", Duration = 154, Genre = "Action, Adventure, Sci-Fi", Title = "Transformers: The Last Knight", Year = 2017 },
                        new { MovieID = "M17-016", BriefStory = "When the network of satellites designed to control the global climate starts to attack Earth, it's a race against the clock for its creator to uncover the real threat before a worldwide Geostorm wipes out everything and everyone.", Cast = "Gerard Butler, Jim Sturgess, Abbie Cornish, Alexandra Maria Lara", Category = "PG-13", Director = " Dean Devlin", Duration = 109, Genre = "Action, Sci-Fi, Thriller", Title = "Geostorm", Year = 2017 },
                        new { MovieID = "M17-017", BriefStory = "While Christian wrestles with his inner demons, Anastasia must confront the anger and envy of the women who came before her.", Cast = "Dakota Johnson, Jamie Dornan, Eric Johnson, Eloise Mumford", Category = "R", Director = "James Foley", Duration = 118, Genre = "Drama, Romance", Title = "Fifty Shades Darker ", Year = 2017 },
                        new { MovieID = "M17-018", BriefStory = "A detective must work with an Orc to find a powerful wand before evil creatures do.", Cast = "Will Smith, Joel Edgerton, Noomi Rapace, Edgar Ramírez", Category = "TV-MA", Director = "David Ayer", Duration = 117, Genre = "Action, Crime, Fantasy", Title = "Bright", Year = 2017 },
                        new { MovieID = "M17-019", BriefStory = "The last Gunslinger: Roland Deschain, has been locked in an eternal battle with Walter O'Dim, also known as the Man in Black, and determined to prevent him from toppling the Dark Tower that holds the universe together. With the fate of the world at stake, good and evil will collide in the ultimate battle, as only Roland can defend the Tower from the Man in Black.", Cast = "Idris Elba, Matthew McConaughey, Tom Taylor, Dennis Haysbert", Category = "PG-13", Director = "Nikolaj Arcel", Duration = 95, Genre = "Action, Adventure, Fantasy", Title = "The Dark Tower", Year = 2017 },
                        new { MovieID = "M17-020", BriefStory = "A humble businessman with a buried past seeks justice when his daughter is killed in an act of terrorism. A cat-and-mouse conflict ensues with a government official, whose past may hold clues to the killers' identities.", Cast = "Katie Leung, Jackie Chan, Rufus Jones, Mark Tandy", Category = "R", Director = "Martin Campbell ", Duration = 113, Genre = "Action, Crime, Drama", Title = "The Foreigner", Year = 2017 },
                        new { MovieID = "M18-001", BriefStory = "Arthur Curry, the human-born heir to the underwater kingdom of Atlantis, goes on a quest to prevent a war between the worlds of ocean and land.", Cast = "Jason Momoa, Amber Heard, Willem Dafoe, Patrick Wilson", Category = "PG-13", Director = "James Wan", Duration = 143, Genre = "Action, Adventure, Fantasy", Title = "Aquaman", Year = 2018 },
                        new { MovieID = "M18-002", BriefStory = "Teen Miles Morales becomes Spider-Man of his reality, crossing his path with five counterparts from other dimensions to stop a threat for all realities.", Cast = "Shameik Moore, Jake Johnson, Hailee Steinfeld, Mahershala Ali", Category = "PG", Director = "Bob Persichetti, Peter Ramsey, Rodney Rothman", Duration = 117, Genre = "Animation, Action, Adventure", Title = "Spider-Man: Into the Spider-Verse", Year = 2018 },
                        new { MovieID = "M18-003", BriefStory = "T'Challa, heir to the hidden but advanced kingdom of Wakanda, must step forward to lead his people into a new future and must confront a challenger from his country's past.", Cast = "Chadwick Boseman, Michael B. Jordan, Lupita Nyong'o, Danai Gurira", Category = "PG-13", Director = "Ryan Coogler", Duration = 134, Genre = "Action, Adventure, Sci-Fi", Title = "Black Panther ", Year = 2018 },
                        new { MovieID = "M18-004", BriefStory = "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.", Cast = "Robert Downey Jr., Chris Hemsworth, Mark Ruffalo, Chris Evans", Category = "PG-13", Director = "Anthony Russo, Joe Russo", Duration = 149, Genre = "Action, Adventure, Fantasy", Title = "Avengers: Infinity War", Year = 2018 },
                        new { MovieID = "M18-005", BriefStory = "Debbie Ocean gathers an all-female crew to attempt an impossible heist at New York City's yearly Met Gala.", Cast = "Sandra Bullock, Cate Blanchett, Anne Hathaway, Mindy Kaling", Category = "PG-13", Director = "Gary Ross", Duration = 110, Genre = "Action, Comedy, Crime", Title = "Ocean's Eight ", Year = 2018 },
                        new { MovieID = "M18-006", BriefStory = "When a young boy accidentally triggers the universe's most lethal hunters' return to Earth, only a ragtag crew of ex-soldiers and a disgruntled scientist can prevent the end of the human race.", Cast = "Boyd Holbrook, Trevante Rhodes, Jacob Tremblay, Keegan-Michael Key", Category = "R", Director = "Shane Black", Duration = 107, Genre = "Action, Adventure, Sci-Fi", Title = "The Predator ", Year = 2018 },
                        new { MovieID = "M18-007", BriefStory = "When the island's dormant volcano begins roaring to life, Owen and Claire mount a campaign to rescue the remaining dinosaurs from this extinction-level event.", Cast = "Chris Pratt, Bryce Dallas Howard, Rafe Spall, Justice Smith", Category = "PG-13", Director = "J.A. Bayona", Duration = 128, Genre = "Action, Adventure, Sci-Fi", Title = "Jurassic World: Fallen Kingdom", Year = 2018 },
                        new { MovieID = "M18-008", BriefStory = "Lara Croft, the fiercely independent daughter of a missing adventurer, must push herself beyond her limits when she discovers the island where her father disappeared.", Cast = "Alicia Vikander, Dominic West, Walton Goggins, Daniel Wu", Category = "PG-13", Director = "Roar Uthaug", Duration = 119, Genre = "Action, Adventure, Fantasy", Title = "Tomb Raider", Year = 2018 },
                        new { MovieID = "M18-009", BriefStory = "Anastasia and Christian get married, but Jack Hyde continues to threaten their relationship.", Cast = "Dakota Johnson, Jamie Dornan, Eric Johnson, Eloise Mumford", Category = "R", Director = "James Foley", Duration = 105, Genre = "Drama, Romance, Thriller", Title = "Fifty Shades Freed", Year = 2018 },
                        new { MovieID = "M18-010", BriefStory = "A young girl is transported into a magical world of gingerbread soldiers and an army of mice.", Cast = "Mackenzie Foy, Keira Knightley, Morgan Freeman, Helen Mirren", Category = "PG", Director = "Lasse Hallström, Joe Johnston", Duration = 99, Genre = "Adventure, Family, Fantasy", Title = "The Nutcracker and the Four Realms", Year = 2018 },
                        new { MovieID = "M18-011", BriefStory = "The Incredibles hero family takes on a new mission, which involves a change in family roles: Bob Parr (Mr Incredible) must manage the house while his wife Helen (Elastigirl) goes out to save the world.", Cast = "Craig T. Nelson, Holly Hunter, Sarah Vowell, Huck Milner", Category = "PG", Director = "Brad Bird", Duration = 118, Genre = "Animation, Action, Adventure", Title = "Incredibles 2", Year = 2018 },
                        new { MovieID = "M18-012", BriefStory = "Ethan Hunt and his IMF team, along with some familiar allies, race against time after a mission gone wrong.", Cast = "Tom Cruise, Henry Cavill, Ving Rhames, Simon Pegg", Category = "PG-13", Director = "Christopher McQuarrie", Duration = 147, Genre = "Action, Adventure, Thriller", Title = "Mission: Impossible - Fallout", Year = 2018 },
                        new { MovieID = "M18-013", BriefStory = "When three different animals become infected with a dangerous pathogen, a primatologist and a geneticist team up to stop them from destroying Chicago.", Cast = "Dwayne Johnson, Naomie Harris, Malin Akerman, Jeffrey Dean Morgan", Category = "PG-13", Director = "Brad Peyton", Duration = 107, Genre = "Action, Adventure, Sci-Fi", Title = "Rampage", Year = 2018 },
                        new { MovieID = "M18-014", BriefStory = "A failed reporter is bonded to an alien entity, one of many entities who have invaded Earth. But the entity takes a liking to Earth and decides to protect it.", Cast = "Tom Hardy, Michelle Williams, Riz Ahmed, Scott Haze", Category = "PG-13", Director = "Ruben Fleischer", Duration = 112, Genre = "Action, Sci-Fi", Title = "Venom", Year = 2018 },
                        new { MovieID = "M18-015", BriefStory = "Years after he fought his way out of an inescapable prison, Ray Breslin has organized a new top-notch security force. But when one of his team members goes missing, Breslin must return to the hell he once escaped from.", Cast = "Sylvester Stallone, Dave Bautista, Xiaoming Huang, Jesse Metcalfe", Category = "R", Director = "Steven C. Miller", Duration = 96, Genre = "Action, Crime, Mystery", Title = "Escape Plan 2: Hades", Year = 2018 },
                        new { MovieID = "M18-016", BriefStory = "A biologist signs up for a dangerous, secret expedition into a mysterious zone where the laws of nature don't apply.", Cast = "Natalie Portman, Jennifer Jason Leigh, Tessa Thompson, Benedict Wong", Category = "R", Director = "Alex Garland", Duration = 115, Genre = "Adventure, Drama, Horror", Title = "Annihilation", Year = 2018 },
                        new { MovieID = "M18-017", BriefStory = "Parapsychologist Dr. Elise Rainier faces her most fearsome and personal haunting yet, as she is drawn back to her ghostly childhood home, where the terror began.", Cast = "Lin Shaye, Leigh Whannell, Angus Sampson, Kirk Acevedo", Category = "PG-13", Director = "Adam Robitel ", Duration = 103, Genre = "Horror, Mystery, Thriller", Title = "Insidious: The Last Key", Year = 2018 },
                        new { MovieID = "M18-018", BriefStory = "After the disappearance of her scientist father, three peculiar beings send Meg, her brother, and her friend to space in order to find him.", Cast = "Storm Reid, Oprah Winfrey, Reese Witherspoon, Mindy Kaling", Category = "PG", Director = "Ava DuVernay", Duration = 109, Genre = "Adventure, Family, Fantasy", Title = "A Wrinkle in Time", Year = 2018 },
                        new { MovieID = "M18-019", BriefStory = "12 Strong tells the story of the first Special Forces team deployed to Afghanistan after 9/11; under the leadership of a new captain, the team must work with an Afghan warlord to take down the Taliban.", Cast = "Chris Hemsworth, Michael Shannon, Michael Peña, Navid Negahban", Category = "R", Director = "Nicolai Fuglsig", Duration = 130, Genre = "Action, Drama, History", Title = "12 Strong ", Year = 2018 },
                        new { MovieID = "M18-020", BriefStory = "A father has a recurring dream of losing his family. His nightmare turns into reality when the planet is invaded by a force bent on destruction. Fighting for their lives, he comes to realize an unknown strength to keep them safe from harm.", Cast = "Michael Peña, Lizzy Caplan, Amelia Crouch, Erica Tremblay", Category = "TV-MA", Director = "Ben Young", Duration = 95, Genre = "Action, Drama, Sci-Fi", Title = "Extinction", Year = 2018 },
                        new { MovieID = "M18-021", BriefStory = "A Yeti is convinced that the elusive creatures known as \"humans\" really do exist.", Cast = "Channing Tatum, James Corden, Zendaya, Common", Category = "PG", Director = "Karey Kirkpatrick, Jason Reisig", Duration = 96, Genre = "Animation, Adventure, Comedy", Title = "Smallfoot", Year = 2018 },
                        new { MovieID = "M18-022", BriefStory = "A human child raised by wolves must face off against a menacing tiger named Shere Khan, as well as his own origins.", Cast = "Christian Bale, Cate Blanchett, Benedict Cumberbatch, Naomie Harris", Category = "PG-13", Director = "Andy Serkis", Duration = 104, Genre = "Adventure, Drama, Fantasy", Title = "Mowgli: Legend of the Jungle", Year = 2018 },
                        new { MovieID = "M18-023", BriefStory = "After deadly terrorists abduct his niece at a soccer match, an ex-soldier with lethal fighting skills wages a one-man war to save her and prevent mass destruction.", Cast = "Dave Bautista, Pierce Brosnan, Ray Stevenson, Aaron McCusker", Category = "R", Director = "Scott Mann", Duration = 104, Genre = "Action, Drama, Thriller", Title = "Final Score ", Year = 2018 },
                        new { MovieID = "M16-001", BriefStory = "Fearing that the actions of Superman are left unchecked, Batman takes on the Man of Steel, while the world wrestles with what kind of a hero it really needs.", Cast = "Ben Affleck, Henry Cavill, Amy Adams, Jesse Eisenberg", Category = "PG-13", Director = "Zack Snyder", Duration = 151, Genre = "Action, Adventure, Fantasy", Title = "Batman v Superman: Dawn of Justice", Year = 2016 },
                        new { MovieID = "M16-002", BriefStory = "In the 1980s the X-Men must defeat an ancient all-powerful mutant, En Sabah Nur, who intends to thrive through bringing destruction to the world.", Cast = "James McAvoy, Michael Fassbender, Jennifer Lawrence, Nicholas Hoult", Category = "PG-13", Director = "Bryan Singer", Duration = 144, Genre = "Action, Adventure, Sci-Fi", Title = "X-Men: Apocalypse", Year = 2016 },
                        new { MovieID = "M16-003", BriefStory = "The friendly but forgetful blue tang fish, Dory, begins a search for her long-lost parents, and everyone learns a few things about the real meaning of family along the way.", Cast = "Ellen DeGeneres, Albert Brooks, Ed O'Neill, Kaitlin Olson", Category = "PG", Director = "Andrew Stanton, Angus MacLane", Duration = 97, Genre = "Animation, Adventure, Comedy", Title = "Finding Dory", Year = 2016 },
                        new { MovieID = "M16-004", BriefStory = "Tarzan, having acclimated to life in London, is called back to his former home in the jungle to investigate the activities at a mining encampment.", Cast = "Alexander Skarsgård, Rory J. Saper, Christian Stevens, Christoph Waltz", Category = "PG-13", Director = "David Yates", Duration = 110, Genre = "Action, Adventure, Drama", Title = "The Legend of Tarzan", Year = 2016 },
                        new { MovieID = "M16-005", BriefStory = "When Scrat's acorn sends an asteroid to Earth, the Herd must find a way to stop the asteroid from hitting Earth with the help of a returning friend.", Cast = "Ray Romano, Denis Leary, John Leguizamo, Chris Wedge", Category = "PG", Director = "Mike Thurmeier, Galen T. Chu", Duration = 94, Genre = "Animation, Adventure, Comedy", Title = "Ice Age: Collision Course", Year = 2016 },
                        new { MovieID = "M16-006", BriefStory = "After the earth-shattering revelations of Insurgent, Tris must escape with Four beyond the wall that encircles Chicago, to finally discover the shocking truth of the world around them.", Cast = "Shailene Woodley, Theo James, Jeff Daniels, Naomi Watts", Category = "PG-13", Director = "Robert Schwentke", Duration = 120, Genre = "Action, Adventure, Mystery", Title = "Allegiant", Year = 2016 },
                        new { MovieID = "M16-007", BriefStory = "The daughter of an Imperial scientist joins the Rebel Alliance in a risky move to steal the Death Star plans.", Cast = "Felicity Jones, Diego Luna, Alan Tudyk, Donnie Yen", Category = "PG-13", Director = "Gareth Edwards", Duration = 133, Genre = "Action, Adventure, Sci-Fi", Title = "Rogue One: A Star Wars Story", Year = 2016 },
                        new { MovieID = "M16-008", BriefStory = "Four waves of increasingly deadly alien attacks have left most of Earth decimated. Cassie is on the run, desperately trying to save her younger brother.", Cast = "Chloë Grace Moretz, Matthew Zuk, Gabriela Lopez, Bailey Anne Borders", Category = "PG-13", Director = "J Blakeson", Duration = 112, Genre = "Action, Adventure, Drama", Title = "The 5th Wave", Year = 2016 },
                        new { MovieID = "M16-009", BriefStory = "As an Orc horde invades the planet Azeroth using a magic portal, a few human heroes and dissenting Orcs must attempt to stop the true evil behind this war.", Cast = "Travis Fimmel, Paula Patton, Ben Foster, Dominic Cooper", Category = "PG-13", Director = "Duncan Jones", Duration = 123, Genre = "Action, Adventure, Fantasy", Title = "Warcraft: The Beginning ", Year = 2016 },
                        new { MovieID = "M16-010", BriefStory = "The quiet life of a terrier named Max is upended when his owner takes in Duke, a stray whom Max instantly dislikes.", Cast = "Louis C.K., Eric Stonestreet, Kevin Hart, Lake Bell", Category = "PG", Director = "Chris Renaud, Yarrow Cheney", Duration = 87, Genre = "Animation, Adventure, Comedy", Title = "The Secret Life of Pets", Year = 2016 },
                        new { MovieID = "M16-011", BriefStory = "When three overworked and under-appreciated moms are pushed beyond their limits, they ditch their conventional responsibilities for a jolt of long overdue freedom, fun and comedic self-indulgence.", Cast = "Mila Kunis, Kathryn Hahn, Kristen Bell, Christina Applegate", Category = "R", Director = "Jon Lucas, Scott Moore", Duration = 100, Genre = "Comedy", Title = "Bad Moms", Year = 2016 },
                        new { MovieID = "M16-012", BriefStory = "In Ancient Polynesia, when a terrible curse incurred by the Demigod Maui reaches Moana's island, she answers the Ocean's call to seek out the Demigod to set things right.", Cast = "Auli'i Cravalho, Dwayne Johnson, Rachel House, Temuera Morrison", Category = "PG", Director = "Ron Clements, John Musker, Don Hall, Chris Williams ", Duration = 107, Genre = "Animation, Adventure, Comedy", Title = "Moana", Year = 2016 },
                        new { MovieID = "M16-013", BriefStory = "The Coast Guard makes a daring rescue attempt off the coast of Cape Cod after a pair of oil tankers are destroyed during a blizzard in 1952.", Cast = "Chris Pine, Casey Affleck, Ben Foster, Eric Bana", Category = "PG-13", Director = "Craig Gillespie", Duration = 117, Genre = "Action, Drama, History", Title = "The Finest Hours", Year = 2016 },
                        new { MovieID = "M16-014", BriefStory = "Alice returns to where the nightmare began: The Hive in Raccoon City, where the Umbrella Corporation is gathering its forces for a final strike against the only remaining survivors of the apocalypse.", Cast = "Milla Jovovich, Iain Glen, Ali Larter, Shawn Roberts", Category = "R", Director = "Paul W.S. Anderson", Duration = 107, Genre = "Action, Horror, Sci-Fi", Title = "Resident Evil: The Final Chapter", Year = 2016 },
                        new { MovieID = "M16-015", BriefStory = "The NSA's illegal surveillance techniques are leaked to the public by one of the agency's employees, Edward Snowden, in the form of thousands of classified documents distributed to the press.", Cast = "Joseph Gordon-Levitt, Shailene Woodley, Melissa Leo, Zachary Quinto", Category = "R", Director = "Oliver Stone ", Duration = 134, Genre = "Biography, Drama, Thriller", Title = "Snowden", Year = 2016 },
                        new { MovieID = "M16-016", BriefStory = "An inexperienced college student meets a wealthy businessman whose sexual practices put a strain on their relationship.", Cast = "Marlon Wayans, Kali Hawk, Fred Willard, Mike Epps", Category = "R", Director = "Michael Tiddes", Duration = 92, Genre = "Comedy", Title = "Fifty Shades of Black", Year = 2016 },
                        new { MovieID = "M16-017", BriefStory = "A mere 200 yards from shore, surfer Nancy is attacked by a great white shark, with her short journey to safety becoming the ultimate contest of wills.", Cast = "Blake Lively, Óscar Jaenada, Angelo Josue Lozano Corzo, Joseph Salas", Category = "PG-13", Director = "Jaume Collet-Serra", Duration = 86, Genre = "Drama, Horror, Thriller", Title = "The Shallows", Year = 2016 },
                        new { MovieID = "M16-018", BriefStory = "Following a ghost invasion of Manhattan, paranormal enthusiasts Erin Gilbert and Abby Yates, nuclear engineer Jillian Holtzmann, and subway worker Patty Tolan band together to stop the otherworldly threat.", Cast = "Melissa McCarthy, Kristen Wiig, Kate McKinnon, Leslie Jones", Category = "PG-13", Director = "Paul Feig", Duration = 116, Genre = "Action, Comedy, Fantasy", Title = "Ghostbusters ", Year = 2016 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
