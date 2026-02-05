# Working with JERP 3.0 using GitHub Desktop

This guide explains how to clone, fetch, and work with the JERP 3.0 repository using GitHub Desktop.

## 📋 Prerequisites

Before you begin, ensure you have:

1. **GitHub Desktop** installed - Download from [desktop.github.com](https://desktop.github.com)
2. **GitHub Account** with access to the repository
3. **Git configured** with your credentials
4. **.NET 8.0 SDK** installed (for building the project)
5. **SQL Server Express** or compatible database

## 🚀 First-Time Setup: Cloning the Repository

### Method 1: Clone via GitHub Desktop URL

1. **Open GitHub Desktop**

2. **Clone Repository**:
   - Click `File` → `Clone Repository...`
   - Select the `URL` tab
   - Enter the repository URL:
     ```
     https://github.com/ninoyerbas/JERP-3.0
     ```
   - Choose a local path where you want to save the project
   - Click `Clone`

3. **Wait for Download**:
   - GitHub Desktop will download all repository files
   - This may take a few minutes depending on your connection

4. **Verify Clone**:
   - Once complete, you should see the repository in GitHub Desktop
   - The local path will be displayed at the top

### Method 2: Clone via GitHub.com

1. **Visit Repository**:
   - Navigate to: `https://github.com/ninoyerbas/JERP-3.0`
   - Click the green `Code` button
   - Select `Open with GitHub Desktop`

2. **Confirm in GitHub Desktop**:
   - Your browser will open GitHub Desktop
   - Confirm the local path
   - Click `Clone`

## 🔄 Fetching Updates from Remote

After the initial clone, you'll want to keep your local repository up-to-date with the latest changes from the remote repository.

### Fetch Changes

**Fetch** downloads the latest changes from the remote repository without modifying your local files.

1. **Open GitHub Desktop**
2. **Select the JERP-3.0 repository** from the repository dropdown
3. **Fetch Origin**:
   - Click `Repository` → `Fetch Origin` (or press `Ctrl+Shift+F` / `Cmd+Shift+F`)
   - Or click the `Fetch origin` button in the toolbar

4. **Check for Updates**:
   - If updates are available, you'll see a notification
   - The toolbar will show "Pull X commits from origin"

### Pull Changes

**Pull** fetches changes and merges them into your current branch.

1. **After Fetching**, if updates are available:
   - Click `Repository` → `Pull` (or press `Ctrl+Shift+P` / `Cmd+Shift+P`)
   - Or click the `Pull origin` button

2. **Resolve Conflicts** (if any):
   - GitHub Desktop will notify you of conflicts
   - Click `Open in [Your Editor]` to resolve conflicts
   - After resolving, commit the merge

## 🌿 Working with Branches

### View Branches

1. Click the **Current Branch** dropdown at the top
2. You'll see:
   - Current branch (checked)
   - Local branches
   - Remote branches

### Switch Branches

1. Click **Current Branch** dropdown
2. Select the branch you want to switch to
3. Click to switch

### Create a New Branch

1. Click **Current Branch** dropdown
2. Click `New Branch`
3. Enter a branch name (e.g., `feature/my-feature`)
4. Choose the base branch
5. Click `Create Branch`

### Publish a Branch

After creating a local branch:

1. Click `Publish branch` button in the toolbar
2. This pushes your new branch to the remote repository

## 💾 Committing Changes

### View Changes

1. Make changes to files in your local repository
2. GitHub Desktop automatically detects changes
3. Modified files appear in the left sidebar under "Changes"

### Stage and Commit

1. **Review Changes**:
   - Select a file to see the diff on the right
   - Red = deleted lines, Green = added lines

2. **Stage Files**:
   - All files are staged by default
   - Uncheck files you don't want to commit

3. **Write Commit Message**:
   - Enter a summary in the "Summary" field (required)
   - Add detailed description in the "Description" field (optional)

4. **Commit**:
   - Click `Commit to [branch-name]` button

### Push Commits

After committing locally:

1. Click `Push origin` button in the toolbar
2. This uploads your commits to GitHub

## 🔍 Viewing History

### Commit History

1. Click the **History** tab (top left)
2. View list of all commits
3. Click a commit to see:
   - Commit message
   - Author and date
   - Files changed

### Compare Changes

1. Right-click on a commit
2. Select `View on GitHub` to see the commit online
3. Or select files to see diffs

## 📦 Working with the JERP 3.0 Project

### Initial Setup After Clone

After cloning, you need to set up the development environment:

1. **Navigate to Repository Folder**:
   ```bash
   cd C:\Users\[YourUsername]\Documents\GitHub\JERP-3.0
   ```

2. **Restore Dependencies**:
   ```bash
   dotnet restore
   ```

3. **Set Up Database**:
   - Install SQL Server Express if not already installed
   - Create database: `CREATE DATABASE JERP3_DB`
   - Run migrations:
     ```bash
     cd src/JERP.Api
     dotnet ef database update --project ../JERP.Infrastructure
     ```

4. **Build the Project**:
   ```bash
   dotnet build
   ```

5. **Run the API**:
   ```bash
   cd src/JERP.Api
   dotnet run
   ```

### Best Practices

1. **Fetch Regularly**: 
   - Fetch from origin at least once a day
   - Before starting new work
   - Before creating a new branch

2. **Pull Before Push**:
   - Always pull latest changes before pushing
   - Reduces merge conflicts

3. **Commit Often**:
   - Make small, logical commits
   - Write clear commit messages
   - Use present tense (e.g., "Add feature" not "Added feature")

4. **Branch Naming**:
   - Use descriptive names
   - Examples:
     - `feature/add-employee-export`
     - `bugfix/fix-payroll-calculation`
     - `docs/update-readme`

5. **Review Changes**:
   - Always review your changes before committing
   - Ensure no sensitive data (passwords, keys) is committed

## 🛠 Troubleshooting

### Repository Not Showing in GitHub Desktop

**Solution:**
- Go to `File` → `Add Local Repository`
- Browse to your repository folder
- Click `Add Repository`

### Authentication Failed

**Solution:**
- Go to `File` → `Options` → `Accounts`
- Sign out and sign back in
- Or use a Personal Access Token (PAT):
  1. Generate PAT on GitHub.com
  2. Use PAT as password when prompted

### Cannot Fetch/Pull (Uncommitted Changes)

**Solution:**
- Commit or stash your changes first
- In GitHub Desktop: Commit your changes before pulling
- Or use command line: `git stash` to temporarily save changes

### Merge Conflicts

**Solution:**
1. GitHub Desktop will highlight conflicts
2. Click `Open in [Editor]` to resolve
3. Look for conflict markers:
   ```
   <<<<<<< HEAD
   Your changes
   =======
   Incoming changes
   >>>>>>> branch-name
   ```
4. Edit to keep desired changes
5. Remove conflict markers
6. Save file
7. Mark as resolved in GitHub Desktop
8. Commit the merge

### Large File Issues

**Solution:**
- JERP 3.0 uses `.gitignore` to exclude:
  - `bin/` and `obj/` folders
  - `node_modules/`
  - Database files
  - Log files
- Ensure you're not adding these files

### Slow Fetch/Pull

**Solution:**
- Check your internet connection
- Repository is large; initial clone may take time
- Subsequent fetches are incremental and faster

## 🔒 Security Considerations

### Do Not Commit:

- ❌ `appsettings.json` with real connection strings
- ❌ `.env` files with secrets
- ❌ Database backup files
- ❌ API keys or credentials
- ❌ Personal certificates

### Use Instead:

- ✅ `appsettings.Development.json` (gitignored)
- ✅ `.env.local` (gitignored)
- ✅ Environment variables
- ✅ Configuration placeholders in committed files

### Check Before Committing:

1. Review all changes in GitHub Desktop
2. Ensure no sensitive data is included
3. Check that only relevant files are staged

## 📚 Additional Resources

- **GitHub Desktop Documentation**: [docs.github.com/desktop](https://docs.github.com/desktop)
- **Git Basics**: [git-scm.com/doc](https://git-scm.com/doc)
- **JERP 3.0 README**: [README.md](../README.md)
- **Database Setup**: [README.md - Database Configuration](../README.md#️-database-configuration)
- **Multi-Database Guide**: [MULTI-DATABASE-GUIDE.md](MULTI-DATABASE-GUIDE.md)

## 💡 Tips for Efficient Workflow

1. **Use Keyboard Shortcuts**:
   - `Ctrl+Shift+F` / `Cmd+Shift+F`: Fetch
   - `Ctrl+Shift+P` / `Cmd+Shift+P`: Pull
   - `Ctrl+Enter` / `Cmd+Enter`: Commit

2. **Open in External Editor**:
   - Right-click file → `Open in External Editor`
   - Configure your preferred editor in Settings

3. **Open in File Explorer/Finder**:
   - Right-click repository → `Open in Explorer/Finder`
   - Quick access to project files

4. **View on GitHub**:
   - Right-click commit/branch → `View on GitHub`
   - See PR status, issues, actions

5. **Command Line Integration**:
   - `Repository` → `Open in Command Prompt/Terminal`
   - Use Git CLI for advanced operations

## 🎯 Quick Reference

| Task | Action |
|------|--------|
| Clone repository | `File` → `Clone Repository` |
| Fetch updates | Click `Fetch origin` or `Ctrl+Shift+F` |
| Pull changes | Click `Pull origin` or `Ctrl+Shift+P` |
| View changes | Check "Changes" tab |
| Commit | Write message → `Commit to [branch]` |
| Push | Click `Push origin` |
| Create branch | Current Branch → `New Branch` |
| Switch branch | Current Branch → Select branch |
| View history | Click "History" tab |
| Resolve conflicts | Click `Open in [Editor]` → Edit → Commit |

## 📞 Support

For issues specific to:
- **GitHub Desktop**: Check [GitHub Desktop Documentation](https://docs.github.com/desktop)
- **JERP 3.0 Project**: Open an issue at [github.com/ninoyerbas/JERP-3.0/issues](https://github.com/ninoyerbas/JERP-3.0/issues)
- **Git Questions**: See [Git Documentation](https://git-scm.com/doc)

---

**Note**: This guide assumes you have proper access credentials to the JERP 3.0 repository. If you encounter access issues, contact your repository administrator or refer to the [README.md](../README.md) for licensing and access information.
