import { profile } from "./data/profile";
import { experiences } from "./data/experience";
import { projects } from "./data/projects";
// pages/index.js
// pages/index.js
import { User, Briefcase, FolderGit2, ExternalLink } from "lucide-react";

export default function Home() {
  return (
    <div className="container-root">
      {/* SIDEBAR */}
      <aside className="sidebar">
        <div className="profile">
          <h1>{profile.fullName}</h1>
          <h2>{profile.position}</h2>
          <p>{profile.navDescription}</p>
        </div>
        <nav className="sidebar-nav">
          <ul>
            <li><a href="#About"><User size={16} /> About</a></li>
            <li><a href="#Experience"><Briefcase size={16} /> Experience</a></li>
            <li><a href="#Projects"><FolderGit2 size={16} /> Projects</a></li>
          </ul>
        </nav>
      </aside>

      {/* MAIN CONTENT */}
      <main className="main-content">
        {/* ABOUT */}
        <section id="About">
          <h3>About me</h3>
          <p>As an experienced software engineer, I will build and deploy your unique proprietary software,
            tailored for your own unique needs. Customization is endless.</p>
          <p>My primary focus as a software engineer is to provide you with designing, analysing, writing,
            testing and deploying good quality, bug-free code. I am always looking for ways to optimize
            performance and scalability of your desired products.</p>
          <p>Throughout my career, I've had the opportunity to develop software across a variety of settings -
            from <a href="https://www.asml.com/en" className="a-text">european tech giants</a> to <a
              href="https://www.continental.com/en/" className="a-text"> automotive giants</a>, <a
                href="https://cpp.canon/about/corporate-information/worldwide/netherlands/"
                className="a-text">hardware giants</a> and also <a href=" https://cp-pro.de/en/" className="a-text">small software
                  companies.</a></p>
          <p>If you're interested in learning more about me feel free to write me to my <a
            href="mailto:@Model.Email" className="a-text">email</a> address.</p>
        </section>

        {/* EXPERIENCE */}
        <section id="Experience">
          <h3>Experience</h3>
          {experiences.map((exp, i) => (
            <div key={i} className="experience-item">
              <div className="experience-date">{exp.start} — {exp.end}</div>
              <div className="experience-content">
                <div className="experience-header">
                  <strong>{exp.title}</strong> · {exp.company} <a href={exp.urls[0]} className="a-object"><ExternalLink size={18} /></a>
                </div>
                <ul>
                  {exp.description.map((d, j) => <li key={j}>{d}</li>)}
                  {exp.urls.length > 1 &&
                    exp.urls.slice(1).map((url, i) => (
                      <li key={i}>
                        <a href={url} className="a-text">{exp.urlTexts[i]}</a>
                      </li>
                    ))
                  }
                </ul>
                <div className="skills">
                  {exp.skills.map((s) => <span key={s} className="skill-pill">{s}</span>)}
                </div>
              </div>
            </div>
          ))}
          <a href="resume" className="a-text"><h3>View Full Resume Here</h3></a>
        </section>

        {/* PROJECTS */}
        <section id="Projects">
          <h3>Projects</h3>
          {projects.map((p, i) => (
            <div key={i} className="project-item">
              <div className="project-img">
                <img src={p.image} alt={p.title} />
              </div>
              <div className="project-content">
                <div className="project-header">
                  <strong>{p.title}</strong> <a href={p.url} className="a-object"><ExternalLink size={18} /></a>
                </div>
                <p>{p.description}</p>
                <div className="skills">
                  {p.achievements.map((a) => <span key={a} className="skill-pill">{a}</span>)}
                </div>
              </div>
            </div>
          ))}
        </section>
      </main>
    </div>
  );
}
