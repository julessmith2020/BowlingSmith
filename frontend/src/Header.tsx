import logo from './disco.png';

function Header(props: any) {
  return (
    <header className="Bruh">
      <div className="container d-flex align-items-center">
        <div className="logo-container mr-auto">
          <img src={logo} className="logo" alt="logo" />
        </div>
        <div className="col subtitle">
          <h1 className="text-white">{props.title}</h1>
        </div>
      </div>
    </header>
  );
}

export default Header;
