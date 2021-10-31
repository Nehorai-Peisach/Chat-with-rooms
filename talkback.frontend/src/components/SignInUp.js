import { useRef } from 'react';
import '../styles/SignInUp.css';

const SignInUp = ({registerUser}) => {
    
    const container = useRef();

    const signInButton = useRef();
    const signUpButton = useRef();

    const signInClick= () => signInButton.current.click(container.current.classList.remove("right-panel-active"));
    const signUpClick= () => signUpButton.current.click(container.current.classList.add("right-panel-active"));

    return <div>
                <div class="container" ref={container}>
                    <div class="form-container sign-up-container">
                        <form action="#">
                            <h1>Create Account</h1>
                            <input type="text" placeholder="Username" />
                            <input type="password" placeholder="Password" />
                            <input type="password" placeholder="Repeat Password" />
                            <button class='sign-up' onClick={registerUser}>Sign Up</button>
                        </form>
                    </div>
                    <div class="form-container sign-in-container">
                        <form action="#">
                            <h1>Sign in</h1>
                            <input type="text" placeholder="Username" />
                            <input type="password" placeholder="Password" />
                            <button class='sign-in'>Sign In</button>
                        </form>
                    </div>
                    <div class="overlay-container">
                        <div class="overlay">
                            <div class="overlay-panel overlay-left">
                                <h1>Welcome Back!</h1>
                                <p>To keep connected with us please login with your personal info</p>
                                <button class="ghost" ref={signInButton} onClick={signInClick}>Sign In</button>
                            </div>
                            <div class="overlay-panel overlay-right">
                                <h1>Hello, Friend!</h1>
                                <p>Enter your personal details and start journey with us</p>
                                <button class="ghost" ref={signUpButton} onClick={signUpClick}>Sign Up</button>
                            </div>
                        </div>
                    </div>
                </div>
    </div>
}

export default SignInUp;