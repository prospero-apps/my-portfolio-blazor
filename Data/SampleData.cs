//using MyPortfolio.Models;
//using System.Reflection.Emit;
//using System.Runtime.CompilerServices;

//namespace MyPortfolio.Data
//{
//    public class SampleData
//    {
//        public List<Category> Categories { get; set; }
//        public List<Tech> Techs { get; set; }
//        public List<Link> Links { get; set; }
//        public List<PortfolioProject> Projects { get; set; }
//        public SampleData()
//        {
//            // Categories
//            Category webProjectsCategory = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Web Projects",
//                Icon = "bi bi-globe"
//            };

//            Category gamesCategory = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Games",
//                Icon = "bi bi-controller"
//            };

//            Category blenderProjectsCategory = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Blender Projects",
//                Icon = "bi bi-box"
//            };

//            Category booksCategory = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Books",
//                Icon = "bi bi-book-half"
//            };

//            Category onlineCoursesCategory = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Online Courses",
//                Icon = "bi bi-easel"
//            };

//            Category magazinesCategory = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Magazines",
//                Icon = "bi bi-layout-text-window"
//            };

//            Category[] sampleCategories =
//            {
//                webProjectsCategory,
//                gamesCategory,
//                blenderProjectsCategory,
//                booksCategory,
//                onlineCoursesCategory,
//                magazinesCategory
//            };

//            Categories.AddRange(sampleCategories);


//            // Techs
//            Tech csharpTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "C#",
//                Icon = "devicon-csharp-plain"
//            };

//            Tech dotnetTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = ".NET",
//                Icon = "devicon-dotnetcore-plain"
//            };

//            Tech blazorTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Blazor",
//                Icon = "bi bi-credit-card-2-front"
//            };

//            Tech dotnetMauiTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = ".NET MAUI",
//                Icon = "bi bi-phone"
//            };

//            Tech unityTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Unity",
//                Icon = "devicon-unity-original"
//            };

//            Tech htmlTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "HTML",
//                Icon = "devicon-html5-plain"
//            };

//            Tech cssTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "CSS",
//                Icon = "devicon-css3-plain"
//            };

//            Tech javaScriptTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "JavaScript",
//                Icon = "devicon-javascript-plain"
//            };

//            Tech reactTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "React",
//                Icon = "devicon-react-original"
//            };

//            Tech pythonTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Python",
//                Icon = "devicon-python-plain"
//            };

//            Tech blenderTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Blender",
//                Icon = "devicon-blender-original"
//            };

//            Tech azureTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Azure",
//                Icon = "devicon-azure-plain"
//            };

//            Tech msSqlServerTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "MS SQL Server",
//                Icon = "devicon-microsoftsqlserver-plain"
//            };

//            Tech bootstrapTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Bootstrap",
//                Icon = "devicon-bootstrap-plain"
//            };

//            Tech englishTech = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "English",
//                Icon = "bi bi-people"
//            };

//            Tech[] sampleTechs =
//            {
//                csharpTech,
//                dotnetTech,
//                blazorTech,
//                dotnetMauiTech,
//                unityTech,
//                htmlTech,
//                cssTech,
//                javaScriptTech,
//                reactTech,
//                pythonTech,
//                blazorTech,
//                azureTech,
//                msSqlServerTech,
//                bootstrapTech,
//                englishTech
//            };

//            Techs.AddRange(sampleTechs);

//            // Links
//            // Forest Monsters
//            Link forestMonsters_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/forest-monsters",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            Link forestMonsters_yt_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://youtu.be/i7xyMbhdg_8",
//                DisplayText = "YouTube",
//                Icon = "bi bi-youtube"
//            };

//            Link forestMonsters_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.com/posts/unity/forest-monsters-a-2d-platformer-game-made-with-unity",
//                DisplayText = "Prospero Coder blog",
//                Icon = "bi bi-book"
//            };

//            Link forestMonsters_download_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.itch.io/forest-monsters",
//                DisplayText = "Download",
//                Icon = "bi bi-download"
//            };

//            // Slugrace
//            Link slugrace_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/slugrace",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            Link slugrace_yt_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://youtu.be/z24eIFsbEl8",
//                DisplayText = "YouTube",
//                Icon = "bi bi-youtube"
//            };

//            Link slugrace_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.com/blog/posts/kivy",
//                DisplayText = "Prospero Coder blog",
//                Icon = "bi bi-book"
//            };

//            // CV Project
//            Link cvProject_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/cv-project",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            Link cvProject_live_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prospero-apps.github.io/cv-project",
//                DisplayText = "Live",
//                Icon = "bi bi-rocket-takeoff"
//            };

//            // Waldo
//            Link waldo_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/waldo",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            Link waldo_live_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prospero-apps.github.io/waldo",
//                DisplayText = "Live",
//                Icon = "bi bi-rocket-takeoff"
//            };

//            // Abstract Artwork
//            Link abstractArtwork_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            // Arched Cellar
//            Link archedCellar_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            // Bacteria
//            Link bacteria_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            Link bacteria_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.com/posts/blender/bacteria-model-under-electron-microscope",
//                DisplayText = "Prospero Coder blog",
//                Icon = "bi bi-book"
//            };

//            // Funny Characters
//            Link funnyCharacters_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            // Gravestone
//            Link gravestone_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            // Tangled Wire Ball Animation
//            Link tangledWireBallAnimation_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            Link tangledWireBallAnimation_yt_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://youtu.be/crGOEzZ2V6Y",
//                DisplayText = "YouTube",
//                Icon = "bi bi-youtube"
//            };

//            Link tangledWireBallAnimation_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.com/posts/blender/tangled-wire-ball-with-uv-sphere",
//                DisplayText = "Prospero Coder blog",
//                Icon = "bi bi-book"
//            };

//            // Town Houses
//            Link townHouses_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files/Town%20Houses",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            // Treasure Chest
//            Link treasureChest_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files/Treasure%20Chest",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            Link treasureChest_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.com/posts/blender/treasure-chest-model",
//                DisplayText = "Prospero Coder blog",
//                Icon = "bi bi-book"
//            };

//            // Tropical Island
//            Link tropicalIsland_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            // Tunnel Animation
//            Link tunnelAnimation_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            Link tunnelAnimation_yt_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://youtu.be/SPVJAwIuqJs",
//                DisplayText = "YouTube",
//                Icon = "bi bi-youtube"
//            };

//            Link tunnelAnimation_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.com/posts/blender/tunnel-animation-follow-path-constraint",
//                DisplayText = "Prospero Coder blog",
//                Icon = "bi bi-book"
//            };

//            // Alien Creature Animation
//            Link alienCreatureAnimation_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/blender/tree/master/blend%20files",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            Link alienCreatureAnimation_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.com/posts/blender/alien-creature-animation",
//                DisplayText = "Prospero Coder blog",
//                Icon = "bi bi-book"
//            };

//            // GUI Programming with Python and Kivy
//            Link kivyBook_github_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://github.com/prospero-apps/python/tree/master/GUI%20Programming%20with%20Python%20and%20Kivy%20BOOK",
//                DisplayText = "Github",
//                Icon = "devicon-github-original"
//            };

//            Link kivyBook_amazon_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://www.amazon.com/Programming-Python-Kivy-Kamil-Pakula/dp/B09M9CYRCX/ref=asc_df_B09M9CYRCX/?tag=hyprod-20&linkCode=df0&hvadid=564675582183&hvpos=&hvnetw=g&hvrand=10679525743492153029&hvpone=&hvptwo=&hvqmt=&hvdev=c&hvdvcmdl=&hvlocint=&hvlocphy=1014434&hvtargid=pla-1595705564143&psc=1",
//                DisplayText = "Amazon",
//                Icon = "bi bi-bookshelf"
//            };

//            Link kivyBook_webstore_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.com/product/gui-programming-with-python-and-kivy-e-book",
//                DisplayText = "Prospero Coder Store",
//                Icon = "bi bi-cart"
//            };

//            Link kivyBook_yt_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://youtu.be/3W8zDYMBoDk",
//                DisplayText = "YouTube",
//                Icon = "bi bi-youtube"
//            };

//            Link kivyBook_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.com/posts/kivy/my-gui-programming-with-python-and-kivy-book",
//                DisplayText = "Prospero Coder blog",
//                Icon = "bi bi-book"
//            };

//            // Learn Over 400 Phrasal Verbs the Fun Way
//            Link phrasalVerbsBook_amazon_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://www.amazon.com/-/es/Kamil-Pakula/dp/B09RM5XFLS",
//                DisplayText = "Amazon",
//                Icon = "bi bi-bookshelf"
//            };

//            Link phrasalVerbsBook_webstore_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperoenglish.com/product/learn-over-400-phrasal-verbs-the-fun-way",
//                DisplayText = "Prospero English Store",
//                Icon = "bi bi-cart"
//            };

//            Link phrasalVerbsBook_yt_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://youtu.be/yCFe0nKw8JM",
//                DisplayText = "YouTube",
//                Icon = "bi bi-youtube"
//            };

//            Link phrasalVerbsBook_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperoenglish.com/posts/my-learn-over-400-phrasal-verbs-book",
//                DisplayText = "Prospero English blog",
//                Icon = "bi bi-book"
//            };

//            // Python Jumpstart Course
//            Link pythonJumpstartCourse_udemy_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://www.udemy.com/course/python-jumpstart-course",
//                DisplayText = "Udemy",
//                Icon = "bi bi-mortarboard"
//            };

//            // Advanced English - Learn Over 400 Phrasal Verbs
//            Link phrasalVerbsCourse_udemy_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://www.udemy.com/course/advanced-english-learn-over-400-phrasal-verbs",
//                DisplayText = "Udemy",
//                Icon = "bi bi-mortarboard"
//            };

//            Link phrasalVerbsCourse_yt_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://youtu.be/KF_OqSmU554",
//                DisplayText = "YouTube",
//                Icon = "bi bi-youtube"
//            };

//            Link phrasalVerbsCourse_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperoenglish.com/posts/my-learn-over-400-phrasal-verbs-the-fun-way-course",
//                DisplayText = "Prospero English blog",
//                Icon = "bi bi-book"
//            };

//            // Your Panda3D Magazine
//            Link yourPanda3DMagazine_amazon_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://www.amazon.com/Your-Panda3D-Magazine-Kamil-Pakula-ebook/dp/B09SR785WV",
//                DisplayText = "Amazon",
//                Icon = "bi bi-bookshelf"
//            };

//            Link yourPanda3DMagazine_webstore_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.com/product/your-panda3d-magazine-1-1-2022",
//                DisplayText = "Prospero Coder Store",
//                Icon = "bi bi-cart"
//            };

//            Link yourPanda3DMagazine_yt_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://youtu.be/N9_rrQXIuuo",
//                DisplayText = "YouTube",
//                Icon = "bi bi-youtube"
//            };

//            Link yourPanda3DMagazine_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperocoder.com/posts/your-panda3d-magazine-issue-1-2022-1",
//                DisplayText = "Prospero Coder blog",
//                Icon = "bi bi-book"
//            };

//            // Your American English Magazine 1
//            Link aem1_amazon_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://www.amazon.com/Your-American-English-Magazine-2022-ebook/dp/B09SQCZVF1",
//                DisplayText = "Amazon",
//                Icon = "bi bi-bookshelf"
//            };

//            Link aem1_webstore_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperoenglish.com/product/your-american-english-magazine-1-1-2022",
//                DisplayText = "Prospero English Store",
//                Icon = "bi bi-cart"
//            };

//            Link aem1_yt_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://youtu.be/XGlzwmBcsyY",
//                DisplayText = "YouTube",
//                Icon = "bi bi-youtube"
//            };

//            Link aem1_blog_Link = new()
//            {
//                Id = Guid.NewGuid(),
//                Destination = "https://prosperoenglish.com/posts/your-american-english-magazine-issue-1-2022-1",
//                DisplayText = "Prospero English blog",
//                Icon = "bi bi-book"
//            };

//            Link[] sampleLinks =
//            {
//                forestMonsters_github_Link, forestMonsters_yt_Link, forestMonsters_blog_Link, forestMonsters_download_Link,
//                slugrace_github_Link, slugrace_yt_Link, slugrace_blog_Link,
//                cvProject_github_Link, cvProject_live_Link,
//                waldo_github_Link, waldo_live_Link,
//                abstractArtwork_github_Link,
//                archedCellar_github_Link,
//                bacteria_github_Link, bacteria_blog_Link,
//                funnyCharacters_github_Link,
//                gravestone_github_Link,
//                tangledWireBallAnimation_github_Link, tangledWireBallAnimation_yt_Link, tangledWireBallAnimation_blog_Link,
//                townHouses_github_Link,
//                treasureChest_github_Link, treasureChest_blog_Link,
//                tropicalIsland_github_Link,
//                tunnelAnimation_github_Link, tunnelAnimation_yt_Link, tunnelAnimation_blog_Link,
//                alienCreatureAnimation_github_Link, alienCreatureAnimation_blog_Link,
//                kivyBook_github_Link, kivyBook_amazon_Link, kivyBook_webstore_Link, kivyBook_yt_Link, kivyBook_blog_Link,
//                phrasalVerbsBook_amazon_Link, phrasalVerbsBook_webstore_Link, phrasalVerbsBook_yt_Link, phrasalVerbsBook_blog_Link,
//                pythonJumpstartCourse_udemy_Link,
//                phrasalVerbsCourse_udemy_Link, phrasalVerbsCourse_yt_Link, phrasalVerbsCourse_blog_Link,
//                yourPanda3DMagazine_amazon_Link, yourPanda3DMagazine_webstore_Link, yourPanda3DMagazine_yt_Link, yourPanda3DMagazine_blog_Link,
//                aem1_amazon_Link, aem1_webstore_Link, aem1_yt_Link, aem1_blog_Link
//            };

//            Links.AddRange(sampleLinks);

//            // Projects
//            // Forest Monsters
//            PortfolioProject forestMonsters = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Forest Monsters",
//                Description = "A 2D game made with Unity with C# scripting. Your task is to save the enchanted forest from a bad sorcerer. You have to kill lots of monsters on your way. This is a typical platformer game. You jump from platform to platform, collect items, shoot monsters, avoid bombs and poison, move toward the door to the next level. Some of the platforms can move, which makes the game more difficult.",
//                ImageUrl = "images/Forest Monsters.png",
//                Category = gamesCategory,
//                Techs = { csharpTech, unityTech },
//                Links = { forestMonsters_github_Link, forestMonsters_yt_Link, forestMonsters_blog_Link, forestMonsters_download_Link }
//            };


//            // Slugrace
//            PortfolioProject slugrace = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Slugrace",
//                Description = "A 2D game made with Python and Kivy. It can be played by up to four players. Each player places a bet on one of four racing slugs and they either win or lose money. The game is over when there's only one player left with any money, but you can set a different ending condition in the settings screen too, like after a given number of races or after a set period of time.",
//                ImageUrl = "images/Slugrace.png",
//                Category = gamesCategory,
//                Techs = { pythonTech },
//                Links = { slugrace_github_Link, slugrace_yt_Link, slugrace_blog_Link }
//            };

//            // CV Project
//            PortfolioProject cvProject = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "CV Project",
//                Description = "This is my first React project. In this app you can fill in a form with your personal information (like name, address, experience and education) to create a CV. You can also upload a photo. There's also a live preview of the CV, so whatever you type in the form is instantly visualized in the preview on the right.",
//                ImageUrl = "images/cv-project.png",
//                Category = gamesCategory,
//                Techs = { htmlTech, cssTech, javaScriptTech, reactTech },
//                Links = { cvProject_github_Link, cvProject_live_Link }
//            };

//            // Waldo
//            PortfolioProject waldo = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Waldo",
//                Description = "This is a simple version of the popular Where Is Waldo game where you have to find Waldo and some other characters in the image. This isn't easy because there are a great number of characters in the image. If you find all three characters in an image, just try another image. There are three images to choose from. This project uses Firebase as the backend.",
//                ImageUrl = "images/waldo.png",
//                Category = gamesCategory,
//                Techs = { htmlTech, cssTech, javaScriptTech, reactTech },
//                Links = { waldo_github_Link, waldo_live_Link }
//            };

//            // Abstract Artwork
//            PortfolioProject abstractArtwork = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Abstract Artwork",
//                Description = "Abstract artwork, pretty useless, just nice for the eye. You can open the blend file available on Github and tweak it to your heart's content. The options are countless.",
//                ImageUrl = "images/Abstract Artwork.jpg",
//                Category = gamesCategory,
//                Techs = { blenderTech },
//                Links = { abstractArtwork_github_Link }
//            };

//            // Arched Cellar
//            PortfolioProject archedCellar = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Arched Cellar",
//                Description = "A low-poly cellar model with simple texturing. You can import it in Unity or any other game engine and use as an environment for your project.",
//                ImageUrl = "images/Arched Cellar.jpg",
//                Category = gamesCategory,
//                Techs = { blenderTech },
//                Links = { archedCellar_github_Link }
//            };

//            // Bacteria
//            PortfolioProject bacteria = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Bacteria",
//                Description = "Bacteria as seen under an electron microscope. When you use an electron microscope, the object you watch is no longer alive, so the bacteria is not going to be animated. I also have a blog post where you can see how this model was built.",
//                ImageUrl = "images/Bacteria.png",
//                Category = gamesCategory,
//                Techs = { blenderTech },
//                Links = { bacteria_github_Link, bacteria_blog_Link }
//            };

//            // Funny Characters
//            PortfolioProject funnyCharacters = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Funny Characters",
//                Description = "A couple high-poly rigged characters I created in Blender. They are animated, but as they are high-poly, they don't actually lend themselves very well to being used in a game.",
//                ImageUrl = "images/Characters.png",
//                Category = gamesCategory,
//                Techs = { blenderTech },
//                Links = { funnyCharacters_github_Link }
//            };

//            // Gravestone
//            PortfolioProject gravestone = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Gravestone",
//                Description = "A gravestone with some inscriptions on it. It's a high-poly model, so it's not well suited for being used in a game, although it might be used in one as a static game object.",
//                ImageUrl = "images/Gravestone.png",
//                Category = gamesCategory,
//                Techs = { blenderTech },
//                Links = { gravestone_github_Link }
//            };

//            // Tangled Wire Ball Animation
//            PortfolioProject tangledWireBallAnimation = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Tangled Wire Ball Animation",
//                Description = "A simple animation, in which a ball of tangled wire rotates around its Z axis and then moves toward the camera along the Y axis until the camera is inside the ball.",
//                ImageUrl = "images/Tangled Wire Ball.jpg",
//                Category = gamesCategory,
//                Techs = { blenderTech },
//                Links = { tangledWireBallAnimation_github_Link, tangledWireBallAnimation_yt_Link, tangledWireBallAnimation_blog_Link }
//            };

//            // Town Houses
//            PortfolioProject townHouses = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Town Houses",
//                Description = "Five low-poly models of town houses, ready to export to Unity or any other game engine. The models are fully textured.",
//                ImageUrl = "images/Town Houses.png",
//                Category = gamesCategory,
//                Techs = { blenderTech },
//                Links = { townHouses_github_Link }
//            };

//            // Treasure Chest
//            PortfolioProject treasureChest = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Treasure Chest",
//                Description = "A model of a chest with an open lid and light coming out of it. If you want to model the chest along with me, just follow the step-by-step instructions in my blog post.",
//                ImageUrl = "images/Treasure Chest.jpg",
//                Category = gamesCategory,
//                Techs = { blenderTech },
//                Links = { treasureChest_github_Link, treasureChest_blog_Link }
//            };

//            // Tropical Island
//            PortfolioProject tropicalIsland = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Tropical Island",
//                Description = "A tropical island with dense vegetation and the sea. The model is high-poly, so not very well suited for being used in a game. It consists of numerous smaller models of plants and stones that I created before.",
//                ImageUrl = "images/Tropical Island.jpg",
//                Category = gamesCategory,
//                Techs = { blenderTech },
//                Links = { tropicalIsland_github_Link }
//            };

//            // Tunnel Animation
//            PortfolioProject tunnelAnimation = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Tunnel Animation",
//                Description = "A simple first-person-perspective animated journey through a tunnel - a tunnel animation using the follow path constraint, in which the camera will move along a path inside a tunnel.",
//                ImageUrl = "images/Tunnel.jpg",
//                Category = gamesCategory,
//                Techs = { blenderTech },
//                Links = { tunnelAnimation_github_Link, tunnelAnimation_yt_Link, tunnelAnimation_blog_Link }
//            };

//            // Alien Creature Animation
//            PortfolioProject alienCreatureAnimation = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Alien Creature Animation",
//                Description = "A simple animation of a worm winding its body. You can read my blog post with step-by-step instructions to first model and then animate along the worm.",
//                ImageUrl = "images/Worm.jpg",
//                Category = gamesCategory,
//                Techs = { blenderTech },
//                Links = { alienCreatureAnimation_github_Link, alienCreatureAnimation_blog_Link }
//            };

//            // GUI Programming with Python and Kivy
//            PortfolioProject kivyBook = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "GUI Programming with Python and Kivy",
//                Description = "This is a book for Python developers who want to create GUI apps using this language. One option is to use the Kivy library. In the book a game project is created from scratch.",
//                ImageUrl = "images/Kivy Book.png",
//                Category = gamesCategory,
//                Techs = { pythonTech },
//                Links = { kivyBook_github_Link, kivyBook_amazon_Link, kivyBook_webstore_Link, kivyBook_yt_Link, kivyBook_blog_Link }
//            };

//            // Learn Over 400 Phrasal Verbs the Fun Way
//            PortfolioProject phrasalVerbsBook = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Learn Over 400 Phrasal Verbs the Fun Way",
//                Description = "In this book you will learn over 400 hundred phrasal verbs. Phrasal verbs are verbs that consist of two parts, the actual verb and a particle, like 'stand up', 'get off' or 'turn down', to mention just a few.",
//                ImageUrl = "images/Phrasal Verbs Book.png",
//                Category = gamesCategory,
//                Techs = { englishTech },
//                Links = { phrasalVerbsBook_amazon_Link, phrasalVerbsBook_webstore_Link, phrasalVerbsBook_yt_Link, phrasalVerbsBook_blog_Link }
//            };

//            // Python Jumpstart Course
//            PortfolioProject pythonJumpstartCourse = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Python Jumpstart Course",
//                Description = "A Python course for absolute beginners. Lots of examples, exercises and projects for you to do. Includes the object-oriented programming paradigm.",
//                ImageUrl = "images/Python Jumpstart Course.png",
//                Category = gamesCategory,
//                Techs = { pythonTech },
//                Links = { pythonJumpstartCourse_udemy_Link }
//            };


//            // Advanced English - Learn Over 400 Phrasal Verbs
//            PortfolioProject phrasalVerbsCourse = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Advanced English - Learn Over 400 Phrasal Verbs",
//                Description = "In this course you will learn over 400 phrasal verbs. Phrasal verbs are very popular especially in everyday colloquial language and using them makes you sound more like a native.",
//                ImageUrl = "images/Phrasal Verbs Course.png",
//                Category = gamesCategory,
//                Techs = { englishTech },
//                Links = { phrasalVerbsCourse_udemy_Link, phrasalVerbsCourse_yt_Link, phrasalVerbsCourse_blog_Link }
//            };

//            // Your Panda3D Magazine
//            PortfolioProject yourPanda3DMagazine = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Your Panda3D Magazine",
//                Description = "This is the first (and so far only) issue of a magazine focused on game development with Python and the Panda3D game engine. There's also quite a lot stuff related to 3D modeling with Blender.",
//                ImageUrl = "images/Your Panda3D Magazine.png",
//                Category = gamesCategory,
//                Techs = { pythonTech },
//                Links = { yourPanda3DMagazine_amazon_Link, yourPanda3DMagazine_webstore_Link, yourPanda3DMagazine_yt_Link, yourPanda3DMagazine_blog_Link }
//            };

//            // Your American English Magazine 1
//            PortfolioProject aem1 = new()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Your American English Magazine",
//                Description = "This is the first issue of Your American English Magazine. There's quite a lot of stuff in it for you that you can use to improve your English, both grammar and vocabulary. Plus some American culture.",
//                ImageUrl = "images/Your American English Magazine.png",
//                Category = gamesCategory,
//                Techs = { englishTech },
//                Links = { aem1_amazon_Link, aem1_webstore_Link, aem1_yt_Link, aem1_blog_Link }
//            };

//            PortfolioProject[] sampleProjects =
//            {
//                forestMonsters,
//                slugrace,
//                cvProject,
//                waldo,
//                abstractArtwork,
//                archedCellar,
//                bacteria,
//                funnyCharacters,
//                gravestone,
//                tangledWireBallAnimation,
//                townHouses,
//                treasureChest,
//                tropicalIsland,
//                tunnelAnimation,
//                alienCreatureAnimation,
//                kivyBook,
//                phrasalVerbsBook,
//                pythonJumpstartCourse,
//                phrasalVerbsCourse,
//                yourPanda3DMagazine,
//                aem1
//            };

//            Projects.AddRange(sampleProjects);
//        }
//    }
//}
