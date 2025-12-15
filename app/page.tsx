import { profile } from "./data/profile";
import { experiences } from "./data/experience";
import { projects } from "./data/projects";
import {
  User,
  Briefcase,
  FolderGit2,
  ExternalLink,
  Mail
} from "lucide-react";

export default function Home() {
  return (
    <div className="container-root">

      {/* NAV — 30% */}
      <nav className="nav-container p-4">
        <div className="nav-title">{profile.fullName}</div>
        <div className="nav-subtitle">{profile.position}</div>
        <div className="nav-text">{profile.navDescription}</div>

        <ul id="sectionNav" className="nav nav-pills flex-column gap-2 mt-4">
          <li>
            <a className="nav-link d-flex align-items-center gap-2" href="#About">
              <User size={16} /> About
            </a>
          </li>
          <li>
            <a className="nav-link d-flex align-items-center gap-2" href="#Experience">
              <Briefcase size={16} /> Experience
            </a>
          </li>
          <li>
            <a className="nav-link d-flex align-items-center gap-2" href="#Projects">
              <FolderGit2 size={16} /> Projects
            </a>
          </li>
        </ul>
      </nav>

      {/* CONTENT — 70% */}
      <main className="content-container">

        {/* ABOUT */}
        <section id="About">
          <h2 className="section-title">About</h2>

          <p>
            As an experienced software engineer, I build and deploy proprietary
            software tailored to specific business needs.
          </p>

          <p>
            My focus is on designing, writing, testing, and deploying
            high-quality, scalable, and maintainable systems.
          </p>

          <p>
            I’ve worked with
            <a href="https://www.asml.com/en" className="a-text"> European tech giants</a>,
            <a href="https://www.continental.com/en/" className="a-text"> automotive leaders</a>,
            <a
              href="https://cpp.canon/about/corporate-information/worldwide/netherlands/"
              className="a-text"
            > hardware companies</a>,
            and <a href="https://cp-pro.de/en/" className="a-text">small software firms</a>.
          </p>

          <p className="d-flex align-items-center gap-2">
            <Mail size={16} />
            <a href="mailto:pieleanuandrei2001@gmail.com" className="a-text">
              pieleanuandrei2001@gmail.com
            </a>
          </p>
        </section>

        {/* EXPERIENCE */}
        <section id="Experience">
          <h2 className="section-title">Experience</h2>

          {experiences.map((exp, i) => (
            <a
              key={i}
              href={exp.urls[0]}
              target="_blank"
              className="experience-link"
            >
              <div className="experience-item d-flex mb-5">
                <div className="experience-date">
                  {exp.start} — {exp.end}
                </div>

                <div className="experience-content ms-4">
                  <div className="experience-header d-flex align-items-center gap-2">
                    <span className="experience-title">{exp.title}</span>
                    <span className="experience-company">· {exp.company}</span>
                    <ExternalLink size={14} />
                  </div>

                  <ul className="experience-description">
                    {exp.description.map((d, j) => (
                      <li key={j}>{d}</li>
                    ))}
                  </ul>

                  <div className="experience-skills">
                    {exp.skills.map((s) => (
                      <span key={s} className="skill-pill">{s}</span>
                    ))}
                  </div>
                </div>
              </div>
            </a>
          ))}
        </section>

        {/* PROJECTS */}
        <section id="Projects">
          <h2 className="section-title">Projects</h2>

          {projects.map((p, i) => (
            <a
              key={i}
              href={p.url}
              target="_blank"
              className="project-link"
            >
              <div className="project-item d-flex mb-5">
                <div className="project-date">
                  <img src={p.image} alt={p.title} />
                </div>

                <div className="project-content ms-4">
                  <div className="d-flex align-items-center gap-2">
                    <span className="project-title">{p.title}</span>
                    <ExternalLink size={14} />
                  </div>

                  <div className="project-description">{p.description}</div>

                  <div className="project-skills">
                    {p.achievements.map((a) => (
                      <span key={a} className="skill-pill">{a}</span>
                    ))}
                  </div>
                </div>
              </div>
            </a>
          ))}
        </section>

      </main>
    </div>
  );
}
